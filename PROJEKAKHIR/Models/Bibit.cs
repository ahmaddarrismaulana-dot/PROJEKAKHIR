using System;

namespace PROJEKAKHIR.Models
{
    public class Bibit
    {
        public int id_bibit { get; set; }
        public int id_toko { get; set; }
        public Kategori id_kategori { get; set; }
        public string nama_bibit { get; set; }
        public int harga { get; set; }
        public int stok { get; set; }
        public string umur_bibit { get; set; } // Ubah dari int ke string
        public string deskripsi { get; set; }
        public byte[] foto_bibit { get; set; } // Ubah dari image ke foto_bibit
        public string nama_kategori { get; set; } // Untuk menampung nama kategori
    }
}