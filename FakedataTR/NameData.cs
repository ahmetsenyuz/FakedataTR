using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakedataTR
{
    public class NameData
    {
        string[] isimler = { "Ahmet", "Mehmet", "Veli", "Ayşe", "Fatma", "Hayriye", "Süleyman", "Ertuğrul" };
        string[] soyad = { "Yılmaz", "Şenyüz", "Aslan", "Şimşek", "Kahraman", "Keskin", "Korkmaz", "Şahin" };
        static Random rnd = new Random();
        public string Ad()
        {
            return isimler[rnd.Next(0, isimler.Length)];
        }
        public string Soyad()
        {
            return soyad[rnd.Next(0, soyad.Length)];
        }
        public string TamAd()
        {
            return Ad()+" "+Soyad(); ;
        }
    }
}
