using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public  class Program
    {
        static void Main(string[] args)
        {
            kullanici k1 = new kullanici(1, "Ayşe", "Söğüt");
            k1.BilgileriGoster();
            k1.zamYap(400);
            Console.ReadLine();

        }
    }
}
