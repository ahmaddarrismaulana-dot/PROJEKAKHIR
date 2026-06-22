using BibitKu.Helpers;
using Npgsql;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;

namespace BibitKu.Controllers
{
    

    public class TransaksiMasukController
    {
        // Ambil semua transaksi masuk untuk penjual berdasarkan id_toko
        public List<TransaksiMasukModel> GetTransaksiMasuk(
     int idToko,
     DateTime? dari = null,
     DateTime? sampai = null,
     string statusFilter = "Semua Status",
     string keyword = "")
        {
            var daftar = new List<TransaksiMasukModel>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT DISTINCT
                    t.id_transaksi,
                    t.tanggal_transaksi,
                    u.nama         AS nama_pembeli,
                    t.total_harga,
                    p.metode_pembayaran,
                    t.status_pesanan,
                    p.status_pembayaran
                FROM public.""Transaksi"" t
                INNER JOIN public.""User"" u
                    ON t.id_user = u.id
                INNER JOIN public.""Detail_Transaksi"" dt
                    ON dt.id_transaksi = t.id_transaksi
                INNER JOIN public.bibit b
                    ON b.id_bibit = dt.id_bibit
                LEFT JOIN public.""Pembayaran"" p
                    ON p.id_transaksi = t.id_transaksi
                WHERE b.id_toko = @id_toko";

                    if (dari.HasValue)
                        query += " AND t.tanggal_transaksi >= @dari";
                    if (sampai.HasValue)
                        query += " AND t.tanggal_transaksi <= @sampai";
                    if (statusFilter != "Semua Status" && !string.IsNullOrEmpty(statusFilter))
                        query += " AND t.status_pesanan = @status";
                    if (!string.IsNullOrWhiteSpace(keyword))
                        query += @" AND (u.nama ILIKE @keyword
                           OR CAST(t.id_transaksi AS TEXT) ILIKE @keyword)";

                    query += " ORDER BY t.id_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_toko", idToko);

                        // ✅ Konversi DateTime → DateOnly untuk parameter
                        if (dari.HasValue)
                            cmd.Parameters.AddWithValue("dari",
                                DateOnly.FromDateTime(dari.Value.Date));
                        if (sampai.HasValue)
                            cmd.Parameters.AddWithValue("sampai",
                                DateOnly.FromDateTime(sampai.Value.Date));
                        if (statusFilter != "Semua Status" && !string.IsNullOrEmpty(statusFilter))
                            cmd.Parameters.AddWithValue("status", statusFilter);
                        if (!string.IsNullOrWhiteSpace(keyword))
                            cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new TransaksiMasukModel();

                                item.id_transaksi =
                                    Convert.ToInt32(reader["id_transaksi"]);

                                // ✅ Cast ke DateOnly lalu ToString
                                var tgl = (DateOnly)reader["tanggal_transaksi"];
                                item.tanggal = tgl.ToString("dd/MM/yyyy");

                                item.nama_pembeli =
                                    reader["nama_pembeli"].ToString();

                                item.total_harga =
                                    Convert.ToInt64(reader["total_harga"]);

                                item.metode_pembayaran =
                                    reader["metode_pembayaran"] == DBNull.Value
                                    ? "-"
                                    : reader["metode_pembayaran"].ToString();

                                item.status_pesanan =
                                    reader["status_pesanan"].ToString();

                                item.status_pembayaran =
                                    reader["status_pembayaran"] == DBNull.Value
                                    ? "-"
                                    : reader["status_pembayaran"].ToString();

                                daftar.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil transaksi masuk: " + ex.Message);
            }

            return daftar;
        }

        // Update status pesanan
        public bool UpdateStatusPesanan(int idTransaksi, string statusBaru)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE public.""Transaksi""
                        SET status_pesanan = @status
                        WHERE id_transaksi = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("status", statusBaru);
                        cmd.Parameters.AddWithValue("id", idTransaksi);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal update status: " + ex.Message);
            }
        }

        // Update status pembayaran jadi Lunas
        public bool KonfirmasiPembayaran(int idTransaksi)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE public.""Pembayaran""
                        SET status_pembayaran = 'Lunas'
                        WHERE id_transaksi = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", idTransaksi);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal konfirmasi pembayaran: " + ex.Message);
            }
        }
    }
}