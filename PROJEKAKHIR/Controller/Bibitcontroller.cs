using BibitKu.Helpers;
using Npgsql;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;

namespace Bibitku.Controllers
{
    public class BibitController
    {
        // TAMBAH BIBIT
        public bool TambahBibit(Bibit bibit)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO public.bibit
                        (
                            id_toko,
                            id_kategori,
                            nama_bibit,
                            harga,
                            stok,
                            umur_bibit,
                            deskripsi,
                            foto_bibit
                        )
                        VALUES
                        (
                            @id_toko,
                            @id_kategori,
                            @nama_bibit,
                            @harga,
                            @stok,
                            @umur_bibit,
                            @deskripsi,
                            @foto_bibit
                        )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_toko", bibit.id_toko.id_Toko);
                        cmd.Parameters.AddWithValue("id_kategori", bibit.id_kategori.id_kategori);
                        cmd.Parameters.AddWithValue("nama_bibit", bibit.nama_bibit);
                        cmd.Parameters.AddWithValue("harga", bibit.harga);
                        cmd.Parameters.AddWithValue("stok", bibit.stok);
                        cmd.Parameters.AddWithValue("umur_bibit", bibit.umur_bibit);
                        cmd.Parameters.AddWithValue("deskripsi", bibit.deskripsi);
                        cmd.Parameters.AddWithValue("foto_bibit", bibit.foto_bibit ?? (object)DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambah bibit: " + ex.Message);
            }
        }

        // MENAMPILKAN SEMUA DATA BIBIT
        public List<Bibit> GetAllBibit()
        {
            List<Bibit> daftarBibit = new List<Bibit>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT b.*, kb.""nama_kategori"" 
                FROM bibit b
                LEFT JOIN ""Kategori_Bibit"" kb ON b.""id_kategori"" = kb.""id_kategori""
                ORDER BY b.""id_bibit""";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bibit bibit = new Bibit();
                            bibit.id_bibit = Convert.ToInt32(reader["id_bibit"]);
                            bibit.nama_bibit = reader["nama_bibit"].ToString();
                            bibit.harga = Convert.ToInt32(reader["harga"]);
                            bibit.stok = Convert.ToInt32(reader["stok"]);
                            bibit.umur_bibit = reader["umur_bibit"].ToString();
                            bibit.deskripsi = reader["deskripsi"].ToString();
                            bibit.foto_bibit = reader["foto_bibit"] as byte[];

                            // Ambil nama_kategori jika ada
                            if (reader["nama_kategori"] != DBNull.Value)
                            {
                                bibit.nama_kategori = reader["nama_kategori"].ToString();
                            }
                            else
                            {
                                bibit.nama_kategori = "-";
                            }

                            daftarBibit.Add(bibit);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data bibit: " + ex.Message);
            }

            return daftarBibit;
        }

        // UPDATE BIBIT
        public bool UpdateBibit(Bibit bibit)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE public.bibit
                        SET
                            id_kategori = @id_kategori,
                            nama_bibit = @nama_bibit,
                            harga = @harga,
                            stok = @stok,
                            umur_bibit = @umur_bibit,
                            deskripsi = @deskripsi,
                            foto_bibit = @foto_bibit
                        WHERE id_bibit = @id_bibit";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_bibit", bibit.id_bibit);
                        cmd.Parameters.AddWithValue("id_kategori", bibit.id_kategori.id_kategori);
                        cmd.Parameters.AddWithValue("nama_bibit", bibit.nama_bibit);
                        cmd.Parameters.AddWithValue("harga", bibit.harga);
                        cmd.Parameters.AddWithValue("stok", bibit.stok);
                        cmd.Parameters.AddWithValue("umur_bibit", bibit.umur_bibit);
                        cmd.Parameters.AddWithValue("deskripsi", bibit.deskripsi);
                        cmd.Parameters.AddWithValue("foto_bibit", bibit.foto_bibit ?? (object)DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal update bibit: " + ex.Message);
            }
        }

        // HAPUS BIBIT
        public bool HapusBibit(int idBibit)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM public.\"Bibit\" WHERE id_bibit = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", idBibit);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus bibit: " + ex.Message);
            }
        }

        // CARI BIBIT
        public List<Bibit> CariBibit(string keyword)
        {
            List<Bibit> daftarBibit = new List<Bibit>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT b.*, kb.nama_kategori 
                        FROM public.bibit b
                        LEFT JOIN public.""Kategori_Bibit"" kb ON b.id_kategori = kb.id_kategori
                        WHERE b.nama_bibit ILIKE @keyword";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("keyword", "%" + keyword + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Bibit bibit = new Bibit();
                                bibit.id_bibit = Convert.ToInt32(reader["id_bibit"]);
                                bibit.nama_bibit = reader["nama_bibit"].ToString();
                                bibit.harga = Convert.ToInt32(reader["harga"]);
                                bibit.stok = Convert.ToInt32(reader["stok"]);
                                bibit.umur_bibit = reader["umur_bibit"].ToString();
                                bibit.deskripsi = reader["deskripsi"].ToString();
                                bibit.foto_bibit = reader["foto_bibit"] as byte[];
                                bibit.nama_kategori = reader["nama_kategori"]?.ToString() ?? "-";

                                daftarBibit.Add(bibit);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mencari bibit: " + ex.Message);
            }

            return daftarBibit;
        }
    }
}