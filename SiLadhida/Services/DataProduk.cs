using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiLadhida.Model;

namespace SiLadhida.Services
{
    public class DataProduk
    {
        public static Dictionary<string, Dictionary<string, Produk>> _listProduk = new Dictionary<string, Dictionary<string, Produk>>()
        {
            {
                "Bolu", new Dictionary<string, Produk>()
                {
                    { "B1", new Produk("Bolu Coklat", 35000, 10) },
                    { "B2", new Produk("Bolu Strawberry", 35000, 10) },
                    { "B3", new Produk("Bolu Keju", 40000, 8) }
                }
            },
            {
                "Kue Lebaran", new Dictionary<string, Produk>()
                {
                    { "L1", new Produk("Nastar", 50000, 20) },
                    { "L2", new Produk("Kastengel", 55000, 15) },
                    { "L3", new Produk("Putri Salju", 45000, 20) }
                }
            }
        };

        public static Produk AmbilProduk(string jenis, string kode)
        {
            if (_listProduk.ContainsKey(jenis) && _listProduk[jenis].ContainsKey(kode))
            {
                return _listProduk[jenis][kode];
            }
            return null;
        }
    }
}
