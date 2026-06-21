namespace PROJEKAKHIR.Models
{
    public class DetailTransaksi
    {
        public int id_detail { get; set; }

        public int id_transaksi { get; set; }

        public int id_bibit { get; set; }

        public int jumlah { get; set; }

        public long harga_satuan { get; set; }

        public long sub_total { get; set; }

        // hasil JOIN Bibit
        public string nama_bibit { get; set; }

        public byte[] foto_bibit { get; set; }
    }
}