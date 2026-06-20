namespace PROJEKAKHIR.Models
{
    public class Keranjang
    {
        public int id_keranjang { get; set; }
        public int id_user { get; set; }
        public int id_bibit { get; set; }
        public int jumlah { get; set; }
        public long sub_total { get; set; }

        // untuk hasil JOIN
        public string nama_bibit { get; set; }
        public int harga { get; set; }
        public byte[] foto_bibit { get; set; }
    }
}