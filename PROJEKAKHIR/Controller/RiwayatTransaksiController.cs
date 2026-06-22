using BibitKu.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;

namespace BibitKu.Controllers
{
    public class RiwayatTransaksiModel
    {
        public int id_transaksi { get; set; }
        public string tanggal { get; set; }
        public long total_harga { get; set; }
        public string status_pesanan { get; set; }
        public string status_pembayaran { get; set; }
        public string metode_pembayaran { get; set; }
    }

    public class RiwayatTransaksiController
    {
        // mengambil semua riwayat transaksi milik pembeli
        public List<RiwayatTransaksiModel> GetRiwayatByUser(
            int idUser,
            string statusFilter = "Semua")
        {
            var daftar = new List<RiwayatTransaksiModel>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            t.id_transaksi,
                            t.tanggal_transaksi,
                            t.total_harga,
                            t.status_pesanan,
                            p.status_pembayaran,
                            p.metode_pembayaran
                        FROM public.""Transaksi"" t
                        LEFT JOIN public.""Pembayaran"" p
                            ON p.id_transaksi = t.id_transaksi
                        WHERE t.id_user = @id_user";

                    //filter status
                    if (statusFilter != "Semua" && !string.IsNullOrEmpty(statusFilter))
                        query += " AND t.status_pesanan = @status";

                    query += " ORDER BY t.id_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_user", idUser);

                        if (statusFilter != "Semua" && !string.IsNullOrEmpty(statusFilter))
                            cmd.Parameters.AddWithValue("status", statusFilter);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new RiwayatTransaksiModel();

                                item.id_transaksi =
                                    Convert.ToInt32(reader["id_transaksi"]);

                                // ✅ DateOnly karena tipe date di PostgreSQL
                                var tgl = (DateOnly)reader["tanggal_transaksi"];
                                item.tanggal = tgl.ToString("dd/MM/yyyy");

                                item.total_harga =
                                    Convert.ToInt64(reader["total_harga"]);

                                item.status_pesanan =
                                    reader["status_pesanan"].ToString();

                                item.status_pembayaran =
                                    reader["status_pembayaran"] == DBNull.Value
                                    ? "-"
                                    : reader["status_pembayaran"].ToString();

                                item.metode_pembayaran =
                                    reader["metode_pembayaran"] == DBNull.Value
                                    ? "-"
                                    : reader["metode_pembayaran"].ToString();

                                daftar.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil riwayat transaksi: " + ex.Message);
            }

            return daftar;
        }

        //mengambil detail item per transaksi
        public List<string> GetDetailTransaksi(int idTransaksi)
        {
            var daftar = new List<string>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            b.nama_bibit,
                            dt.jumlah,
                            dt.harga_satuan,
                            dt.sub_total
                        FROM public.""Detail_Transaksi"" dt
                        INNER JOIN public.bibit b
                            ON b.id_bibit = dt.id_bibit
                        WHERE dt.id_transaksi = @id_transaksi";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id_transaksi", idTransaksi);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nama = reader["nama_bibit"].ToString();
                                int jumlah = Convert.ToInt32(reader["jumlah"]);
                                long harga = Convert.ToInt64(reader["harga_satuan"]);
                                long subtotal = Convert.ToInt64(reader["sub_total"]);

                                daftar.Add(
                                    $"{nama} x{jumlah} " +
                                    $"@ Rp {harga:N0} = Rp {subtotal:N0}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil detail transaksi: " + ex.Message);
            }

            return daftar;
        }
    }
}