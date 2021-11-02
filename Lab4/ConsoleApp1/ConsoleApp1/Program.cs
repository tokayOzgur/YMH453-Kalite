using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Gezegen
        {
            protected int gezegenSayisi = 9;
            protected string sisteminAdı = "Güneş Sistemi";
            public virtual void bilgiAl()
            {
                Console.WriteLine("Gezegen Sayısı : {0}", gezegenSayisi);

                Console.WriteLine(" Sistemin Adı : {0}", sisteminAdı);

                Console.WriteLine();
            }
        }

        class Mars : Gezegen
        {
            public string gezegenAdı = "Mars";
            public override void bilgiAl()
            {
                base.bilgiAl();
                Console.WriteLine("Gezegen Adı: {0}", gezegenAdı);
            }
        }

        class Uydu : Mars
        {
            private string uyduAdı = "Deimos";
            public void bilgiAl()
            {
                base.bilgiAl();
                Console.WriteLine("Uydusunun Adı : {0} ", uyduAdı);
            }
        }

        static void Main(string[] args)
        {
            // RFC = tetiklenen tüm metotrların sayısıdır.

            Mars m = new Mars();
            m.bilgiAl(); // Mars - Gezegen

            Uydu u = new Uydu();
            u.bilgiAl(); // Uydu - Mars - Gezegen
            Console.ReadLine();
        }
    }
}
