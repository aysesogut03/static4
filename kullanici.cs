using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class kullanici
    {
        private int kullaniciİd{get;set;}
        private string kullaniciAdi { get; set; }
        private string kullaniciSoyadi { get; set; }
        private static int kullanicimaas { get; set; }

        static kullanici()
            {
            kullanicimaas = 79000;
            }

        public kullanici(int kullaniciİd, string kullaniciAdi, string kullaniciSoyadi)
        {
            this.kullaniciİd = kullaniciİd;
            this.kullaniciAdi = kullaniciAdi;
            this.kullaniciSoyadi = kullaniciSoyadi;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Bilgileri goster:");
            Console.WriteLine("kullaniciİd:" + kullaniciİd);
            Console.WriteLine("kullaniciAdi:" + kullaniciAdi);
            Console.WriteLine("kullaniciSoyadi:" + kullaniciSoyadi);
            Console.WriteLine("kullanıcı maaşı:" + kullanicimaas);
        }

        public void zamYap(int eklenenzam)
        {
            Console.WriteLine("KULLANICIYA ZAM YAPILIYOR...");
            Console.WriteLine("kullanıcının yeni maaş:"+ kullanicimaas + eklenenzam);

        }
    }
}
