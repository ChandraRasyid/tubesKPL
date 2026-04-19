using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiLadhida.Model
{
    public class Produk
    {
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Stock { get; set; }

        public Produk(string nama, int harga, int stock)
        {
            this.Nama = nama;
            this.Harga = harga;
            this.Stock = stock;
        }
    }
}
