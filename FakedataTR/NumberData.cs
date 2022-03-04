using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakedataTR
{
    public class NumberData
    {
        static Random rnd = new Random();
        public int GetNumber()//overload
        {
            return rnd.Next();
        }
        public int GetNumber(int max)
        {
            return rnd.Next(max);
        }
        public int GetNumber(int min, int max)
        {
            return rnd.Next(min,max);
        }
        public double GetNumber(bool a = true)// içindeki değer yazılmazsa hata veriyor.
        {
            return rnd.NextDouble();
        }
    }
}
