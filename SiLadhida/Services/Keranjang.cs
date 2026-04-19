using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiLadhida.Model;

namespace SiLadhida.Services
{
    public class Keranjang<T>
    {
        private List<T> daftarPesanan = new List<T>();

        public void TambahPesanan(T pesanan)
        {
            daftarPesanan.Add(pesanan);
        }

        public List<T> PrintDaftarPesanan()
        {
            return daftarPesanan;
        }

        public void ResetDaftarPesanan()
        {
            daftarPesanan.Clear();
        }
    }
}
