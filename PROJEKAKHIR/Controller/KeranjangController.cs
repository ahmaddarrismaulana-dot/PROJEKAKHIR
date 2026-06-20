using BibitKu.Helpers;
using Npgsql;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;

namespace BibitKu.Controllers
{
    public class KeranjangController
    {
        // =====================================================
        // TAMBAH KE KERANJANG
        // =====================================================
        public bool TambahKeKeranjang(
            int idUser,
            int idBibit,
            int jumlah)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Ambil harga bibit
                    int harga = 0;

                    string hargaQuery = @"
                    SELECT harga
                    FROM public.bibit
                    WHERE id_bibit = @id_bibit
                    AND status_aktif = TRUE";

                    using (var hargaCmd = new NpgsqlCommand(hargaQuery, conn))
                    {
                        hargaCmd.Parameters.AddWithValue("id_bibit", idBibit);

                        object hasil = hargaCmd.ExecuteScalar();

                        if (hasil == null)
                        {
                            throw new Exception(
                                "Bibit sudah tidak tersedia atau telah dihapus.");
                        }

                        harga = Convert.ToInt32(hasil);
                    }

                    int subTotal = harga * jumlah;

                    // Cek apakah sudah ada
                    string cekQuery = @"
                    SELECT jumlah_beli
                    FROM public.""Keranjang""
                    WHERE id_user = @id_user
                    AND id_bibit = @id_bibit";

                    using (var cekCmd = new NpgsqlCommand(cekQuery, conn))
                    {
                        cekCmd.Parameters.AddWithValue("id_user", idUser);
                        cekCmd.Parameters.AddWithValue("id_bibit", idBibit);

                        object result = cekCmd.ExecuteScalar();

                        if (result != null)
                        {
                            string updateQuery = @"
                            UPDATE public.""Keranjang""
                            SET
                                jumlah_beli = jumlah_beli + @jumlah,
                                sub_total = sub_total + @sub_total
                            WHERE id_user = @id_user
                            AND id_bibit = @id_bibit";

                            using (var updateCmd =
                                   new NpgsqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("jumlah", jumlah);
                                updateCmd.Parameters.AddWithValue("sub_total", subTotal);
                                updateCmd.Parameters.AddWithValue("id_user", idUser);
                                updateCmd.Parameters.AddWithValue("id_bibit", idBibit);

                                return updateCmd.ExecuteNonQuery() > 0;
                            }
                        }
                        else
                        {
                            string insertQuery = @"
                            INSERT INTO public.""Keranjang""
                            (
                                id_user,
                                id_bibit,
                                jumlah_beli,
                                sub_total
                            )
                            VALUES
                            (
                                @id_user,
                                @id_bibit,
                                @jumlah_beli,
                                @sub_total
                            )";

                            using (var insertCmd =
                                   new NpgsqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("id_user", idUser);
                                insertCmd.Parameters.AddWithValue("id_bibit", idBibit);
                                insertCmd.Parameters.AddWithValue("jumlah_beli", jumlah);
                                insertCmd.Parameters.AddWithValue("sub_total", subTotal);

                                return insertCmd.ExecuteNonQuery() > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Gagal menambah ke keranjang: " + ex.Message);
            }
        }

        // =====================================================
        // AMBIL KERANJANG USER
        // =====================================================
        public List<Keranjang> GetKeranjangByUser(int idUser)
        {
            List<Keranjang> daftar = new List<Keranjang>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        k.id_keranjang,
                        k.id_user,
                        k.id_bibit,
                        k.jumlah_beli,
                        k.sub_total,
                        b.nama_bibit,
                        b.harga,
                        b.foto_bibit
                    FROM public.""Keranjang"" k
                    INNER JOIN public.bibit b
                        ON k.id_bibit = b.id_bibit
                    WHERE k.id_user = @id_user
                    AND b.status_aktif = TRUE";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_user", idUser);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Keranjang item = new Keranjang();

                                item.id_keranjang =
                                    Convert.ToInt32(reader["id_keranjang"]);

                                item.id_user =
                                    Convert.ToInt32(reader["id_user"]);

                                item.id_bibit =
                                    Convert.ToInt32(reader["id_bibit"]);

                                item.jumlah =
                                    Convert.ToInt32(reader["jumlah_beli"]);

                                item.sub_total =
                                    Convert.ToInt64(reader["sub_total"]);

                                item.nama_bibit =
                                    reader["nama_bibit"].ToString();

                                item.harga =
                                    Convert.ToInt32(reader["harga"]);

                                item.foto_bibit =
                                    reader["foto_bibit"] as byte[];

                                daftar.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Gagal mengambil keranjang: " + ex.Message);
            }

            return daftar;
        }

        // =====================================================
        // UPDATE JUMLAH
        // =====================================================
        public bool UpdateJumlah(
            int idKeranjang,
            int jumlahBaru,
            int harga)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    long subtotal = harga * jumlahBaru;

                   string query = @"
                    UPDATE public.""Keranjang""
                    SET
                        jumlah_beli = @jumlah,
                        sub_total = @subtotal
                    WHERE id_keranjang = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("jumlah", jumlahBaru);
                        cmd.Parameters.AddWithValue("subtotal", subtotal);
                        cmd.Parameters.AddWithValue("id", idKeranjang);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Gagal update jumlah: " + ex.Message);
            }
        }

        // =====================================================
        // HAPUS ITEM
        // =====================================================
        public bool HapusItem(int idKeranjang)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    DELETE FROM public.""Keranjang""
                    WHERE id_keranjang = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", idKeranjang);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Gagal menghapus item: " + ex.Message);
            }
        }

        // =====================================================
        // KOSONGKAN KERANJANG
        // =====================================================
        public bool KosongkanKeranjang(int idUser)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                    DELETE FROM public.""Keranjang""
                    WHERE id_user = @id_user";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_user", idUser);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Gagal mengosongkan keranjang: " + ex.Message);
            }
        }
    }
}