using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cate_new
{
    public delegate void Water_herter(int Dwp);
    class Program
    {
       static int Dwp;
       static public void Boilwater(int Dwp)
        {
            Console.WriteLine("开始升温");
            for (Dwp = 37; Dwp < 80; Dwp++)
            {
                Console.WriteLine("水温已经达到了" + Dwp);
            }
            Console.WriteLine("都80°了，你丫是想煮肉啊");
        }
        public static void dwp(Water_herter Boilwater)
        {
            Boilwater(Dwp);
        }
        static void Main(string[] args)
        {
            dwp(Boilwater);

        }
    }
}