using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimKaliteTest
{
    public class Uyg1
    {
        public static int Topla(int x1, int x2, int x3, int x4)
        {
            return x1 + x2 + x3 + x4;
        }
        public static string TersYazdir(string val)
        {
            string newVal = "";
            for (int i = val.Length - 1; i >= 0; i--)
            {
                newVal += val[i];
            }
            return newVal;
        }

        public static int Faktoriyel(int a)
        {
            int f = 1;
            int i = 0;
            for (i = 1; i <= a; i++)
            {

                f = i * f;
            }
            return f;
        }
        public class Akademisyenler
        {
            public string kAdi { get; set; }
            public string sifre { get; set; }
            public string kAdSoyadi { get; set; }
            public string unvan { get; set; }
            public string mail { get; set; }
            public string adres { get; set; }
            public string sonuc { get; set; } // Kıyaslamanın yapılması için konulan prop'tur.
            // Böylelikle burada değerler direkt olarak test edilebilincektir.

            public Akademisyenler(string kAdi, string sifre, string kAdSoyadi, string unvan, string mail, string adres)
            {
                this.kAdi = kAdi;
                this.sifre = sifre;
                this.kAdSoyadi = kAdSoyadi;
                this.mail = mail;
                this.adres = adres;
                this.unvan = unvan;

                this.sonuc = kAdi + " " + sifre + " " + kAdSoyadi + " " + unvan + " " + mail + " " + adres; //Tüm değerleri buraya ekliyip kontrol işlemini yapıyoruz.
            }
        }
        static void Main(string[] args)
        {

            Akademisyenler akd = new Akademisyenler("a", "b", "c", "d", "e", "f");
            string beklenen = "a b c d e f";
            if (beklenen == akd.sonuc)
            {
                Console.WriteLine("İşlem doğru");
            }

            Console.ReadLine();
        }


    }
}
