using BibitKu.Helpers;
using Npgsql;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;

namespace BibitKu.Controllers
{
    public class CheckoutController
    {
        public bool ProsesCheckout(
            int idUser,
            List<PROJEKAKHIR.Models.Keranjang> items,
            string metodePembayaran,
            string bankTujuan,
            byte[] buktiBayar,
            string alamatPengiriman,
            out int idTransaksiBaru)
        {
            idTransaksiBaru = 0;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var trx = conn.BeginTransaction())
                {
                    try
                    {
                        // Hitung total
                        long totalHarga = 0;
                        foreach (var item in items)
                            totalHarga += item.sub_total;

                        // ============================================
                        // 1. INSERT ke Transaksi
                        // ============================================
                        string sqlTransaksi = @"
                            INSERT INTO public.""Transaksi""
                            (id_user, tanggal_transaksi, total_harga, status_pesanan)
                            VALUES (@id_user, CURRENT_DATE, @total_harga, 'Menunggu Pembayaran')
                            RETURNING id_transaksi";

                        using (var cmd = new NpgsqlCommand(sqlTransaksi, conn, trx))
                        {
                            cmd.Parameters.AddWithValue("id_user", idUser);
                            cmd.Parameters.AddWithValue("total_harga", totalHarga);
                            idTransaksiBaru = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // ============================================
                        // 2. INSERT ke Detail_Transaksi + update stok
                        // ============================================
                        foreach (var item in items)
                        {
                            string sqlDetail = @"
                                INSERT INTO public.""Detail_Transaksi""
                                (id_transaksi, id_bibit, jumlah, harga_satuan, sub_total)
                                VALUES (@id_transaksi, @id_bibit, @jumlah, @harga_satuan, @sub_total)";

                            using (var cmd = new NpgsqlCommand(sqlDetail, conn, trx))
                            {
                                cmd.Parameters.AddWithValue("id_transaksi", idTransaksiBaru);
                                cmd.Parameters.AddWithValue("id_bibit", item.id_bibit);
                                cmd.Parameters.AddWithValue("jumlah", item.jumlah);
                                cmd.Parameters.AddWithValue("harga_satuan", (long)item.harga);
                                cmd.Parameters.AddWithValue("sub_total", item.sub_total);
                                cmd.ExecuteNonQuery();
                            }

                            // Kurangi stok bibit
                            string sqlStok = @"
                                UPDATE public.bibit
                                SET stok = stok - @jumlah
                                WHERE id_bibit = @id_bibit";

                            using (var cmd = new NpgsqlCommand(sqlStok, conn, trx))
                            {
                                cmd.Parameters.AddWithValue("jumlah", item.jumlah);
                                cmd.Parameters.AddWithValue("id_bibit", item.id_bibit);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // ============================================
                        // 3. INSERT ke Pembayaran (ada bukti_pembayaran)
                        // ============================================
                        string sqlBayar = @"
                            INSERT INTO public.""Pembayaran""
                            (id_transaksi, metode_pembayaran, total_bayar,
                             status_pembayaran, tanggal_bayar, bukti_pembayaran)
                            VALUES (@id_transaksi, @metode, @total,
                                    'Belum Bayar', NOW(), @bukti)";

                        using (var cmd = new NpgsqlCommand(sqlBayar, conn, trx))
                        {
                            cmd.Parameters.AddWithValue("id_transaksi", idTransaksiBaru);
                            cmd.Parameters.AddWithValue("metode", metodePembayaran);
                            cmd.Parameters.AddWithValue("total", totalHarga);
                            // bukti boleh null
                            cmd.Parameters.AddWithValue("bukti",
                                buktiBayar != null ? (object)buktiBayar : DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        // ============================================
                        // 4. Kosongkan Keranjang user
                        // ============================================
                        string sqlKeranjang = @"
                            DELETE FROM public.""Keranjang""
                            WHERE id_user = @id_user";

                        using (var cmd = new NpgsqlCommand(sqlKeranjang, conn, trx))
                        {
                            cmd.Parameters.AddWithValue("id_user", idUser);
                            cmd.ExecuteNonQuery();
                        }

                        trx.Commit();
                        return true;
                    }
                    catch
                    {
                        trx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}