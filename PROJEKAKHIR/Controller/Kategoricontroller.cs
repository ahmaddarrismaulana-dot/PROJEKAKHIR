using BibitKu.Helpers;
using Npgsql;
using PROJEKAKHIR.Models;
using System;
using System.Collections.Generic;

namespace Bibitku.Controllers
{
    public class KategoriController
    {
        public List<Kategori> GetAllKategori()
        {
            List<Kategori> daftarKategori = new List<Kategori>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_kategori, nama_kategori FROM \"Kategori_Bibit\" ORDER BY id_kategori";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kategori kategori = new Kategori();
                            kategori.id_kategori = Convert.ToInt32(reader["id_kategori"]);
                            kategori.nama_kategori = reader["nama_kategori"].ToString();
                            daftarKategori.Add(kategori);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data kategori: " + ex.Message);
            }

            return daftarKategori;
        }
    }
}