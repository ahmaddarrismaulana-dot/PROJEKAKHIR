using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKAKHIR.Models
{
    public class TransaksiMasukModel
    {
        public int id_transaksi { get; set; }
        public string tanggal { get; set; }
        public string nama_pembeli { get; set; }
        public long total_harga { get; set; }
        public string metode_pembayaran { get; set; }
        public string status_pesanan { get; set; }
        public string status_pembayaran { get; set; }
    }
}
