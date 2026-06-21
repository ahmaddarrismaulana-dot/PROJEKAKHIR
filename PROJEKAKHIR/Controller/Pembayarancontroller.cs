using BibitKu.Helpers;
using Npgsql;

namespace BibitKu.Controllers
{
    public class PembayaranController
    {
        public bool SimpanPembayaran(
            int idTransaksi,
            string metode,
            long totalBayar,
            byte[] bukti)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                INSERT INTO public.""Pembayaran""
                (
                    id_transaksi,
                    metode_pembayaran,
                    total_bayar,
                    status_pembayaran,
                    tanggal_bayar,
                    bukti_pembayaran
                )
                VALUES
                (
                    @id_transaksi,
                    @metode,
                    @total,
                    'Menunggu Verifikasi',
                    NOW(),
                    @bukti
                )";

                using (var cmd =
                    new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "id_transaksi",
                        idTransaksi);

                    cmd.Parameters.AddWithValue(
                        "metode",
                        metode);

                    cmd.Parameters.AddWithValue(
                        "total",
                        totalBayar);

                    cmd.Parameters.AddWithValue(
                        "bukti",
                        bukti);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}