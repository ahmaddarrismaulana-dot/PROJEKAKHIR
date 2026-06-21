namespace PROJEKAKHIR.Models
{
    public class Pembayaran
    {
        public int id_pembayaran { get; set; }

        public int id_transaksi { get; set; }

        public string metode_pembayaran { get; set; }

        public long total_bayar { get; set; }

        public string status_pembayaran { get; set; }

        public DateTime? tanggal_bayar { get; set; }

        public byte[] bukti_pembayaran { get; set; }
    }
}