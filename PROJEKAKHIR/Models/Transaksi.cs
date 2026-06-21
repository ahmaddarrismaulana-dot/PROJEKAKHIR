namespace PROJEKAKHIR.Models
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }

        public int id_user { get; set; }

        public DateTime tanggal_transaksi { get; set; }

        public long total_harga { get; set; }

        public string status_pesanan { get; set; }

        public byte[] foto_bukti { get; set; }

        // JOIN User
        public string nama_pembeli { get; set; }

        public string alamat_pembeli { get; set; }
    }
}