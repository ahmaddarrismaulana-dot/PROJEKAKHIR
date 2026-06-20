using BibitKu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKAKHIR.Models
{
    public class Toko
    {
        public int id_toko {  get; set; }
        public User id_user { get; set; }
        public string nama_toko { get; set; }
        public string deskripsi { get; set; }

    }
}
