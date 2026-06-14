using BibitKu.Helpers;
using Npgsql;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;

namespace Bibitku.Controllers
{
    public class ManajemenStokController
    {
        // Method untuk mendapatkan semua data bibit (untuk ditampilkan di DataGridView)
        public List<Bibit> GetAllBibit()
        {
            List<Bibit> daftarBibit = new List<Bibit>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT b.""id_bibit"", b.""nama_bibit"",
                               b.""stok"", b.""harga"", b.""umur_bibit"", 
                               b.""deskripsi"", kb.""nama_kategori""
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
                            bibit.stok = Convert.ToInt32(reader["stok"]);
                            bibit.harga = Convert.ToInt32(reader["harga"]);
                            bibit.umur_bibit = reader["umur_bibit"].ToString();
                            bibit.deskripsi = reader["deskripsi"].ToString();

                            if (reader["nama_kategori"] != DBNull.Value)
                                bibit.nama_kategori = reader["nama_kategori"].ToString();

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

        // Method untuk mendapatkan ringkasan stok
        public (int totalStok, int stokMenipis, int stokHabis) GetRingkasanStok()
        {
            int totalStok = 0;
            int stokMenipis = 0;
            int stokHabis = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Total stok
                    string queryTotal = "SELECT COALESCE(SUM(\"stok\"), 0) FROM \"bibit\"";
                    using (var cmdTotal = new NpgsqlCommand(queryTotal, conn))
                    {
                        totalStok = Convert.ToInt32(cmdTotal.ExecuteScalar());
                    }

                    // Stok menipis (stok < 20 dan stok > 0)
                    string queryMenipis = "SELECT COUNT(*) FROM \"bibit\" WHERE \"stok\" < 20 AND \"stok\" > 0";
                    using (var cmdMenipis = new NpgsqlCommand(queryMenipis, conn))
                    {
                        stokMenipis = Convert.ToInt32(cmdMenipis.ExecuteScalar());
                    }

                    // Stok habis (stok = 0)
                    string queryHabis = "SELECT COUNT(*) FROM \"bibit\" WHERE \"stok\" = 0";
                    using (var cmdHabis = new NpgsqlCommand(queryHabis, conn))
                    {
                        stokHabis = Convert.ToInt32(cmdHabis.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil ringkasan stok: " + ex.Message);
            }

            return (totalStok, stokMenipis, stokHabis);
        }

        // Method untuk update stok
        public bool UpdateStok(int idBibit, int jumlahBaru, string tipePenyesuaian)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE \"bibit\" SET \"stok\" = @stok WHERE \"id_bibit\" = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("stok", jumlahBaru);
                        cmd.Parameters.AddWithValue("id", idBibit);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal update stok: " + ex.Message);
            }
        }

        // Method untuk mendapatkan status stok (untuk warna di DataGridView)
        public string GetStatusStok(int stok)
        {
            if (stok == 0)
                return "Habis";
            else if (stok < 20)
                return "Menipis";
            else
                return "Tersedia";
        }
    }
}