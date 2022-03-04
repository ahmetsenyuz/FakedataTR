using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakedataTR
{
    public class AdressData
    {
        string[] sehir = { "Istanbul", "Adana", "Izmir", "Ankara", "Bayburt", "Adıyaman", "Kars", "Ağrı" };
        string[] cadde = { "Atatürk Caddesi","Kızılay","4. Cadde","Sultanmurat","2.Cadde" };
        static Random rnd = new Random();
        public string Sehir()
        {
            //int c = rnd.Next(0, sehir.Length);
            //return sehir[c];
            return sehir[rnd.Next(0, sehir.Length)];
        }
        public string Cadde()
        {
            return cadde[rnd.Next(0, cadde.Length)];
        }
    }
}
