using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YazilimKaliteTest;
using static YazilimKaliteTest.Uyg1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestTopla()
        {
            int sonuc = Uyg1.Topla(10, 10, 20, 20);
            Assert.AreEqual(sonuc, 70);
        }

        [TestMethod]
        public void TerstenTest()
        {
            string sonuc = Uyg1.TersYazdir("deneme");
            Assert.AreEqual(sonuc, "emeneda");
        }

        [TestMethod]
        public void TestFack()
        {
            int sonuc = Uyg1.Faktoriyel(5);
            Assert.AreEqual(sonuc, 10);
        }

        // Diğer sorulardan tam puan almış olup kurtarma haftasında düeltmek istediğim tek uygulama aşağıdakidir.
        // Bu uygulama 45p değerindedir.
        [TestMethod]
        public void TestAkad()
        {
            /*
             * her nesneye birim test uygulanabilir. Ama daha hızlı bir sonuç için Sınıftaki nesneler 
             * tek bir nesne üzerine alınıp. Kontrol işlemi yapılıyor.
             * Diğer Sorulardan tam puan almış olup tek eksiğim bu uygulama sorusudur.
            */

            // Deneme Uygulaması
            Uyg1.Akademisyenler akd = new Uyg1.Akademisyenler("a", "b", "c", "d", "e", "f");
            string beklenen = "a b c d e f"; //beklenen değerimizi bu şekilde belirttik
            Assert.AreEqual(beklenen, akd.sonuc);

            // Tablodaki değerler
            Akademisyenler Nesne1 = new Akademisyenler("rdas", "785123", "Resul Daş", "Prof. Dr.", "resuldas@gmail.com", "Elazığ");
            Akademisyenler Nesne2 = new Akademisyenler("mbaykara", "457856", "Muhammet Baykara", "Dr. Öğr. Üyesi", "muhammetbaykara23@gmail.com", "Elazığ");
            Akademisyenler Nesne3 = new Akademisyenler("tbalakus", "123456", "Talha Burak Alakuş", "Arş. Gör.", "burak.alakuss@gmail.com", "Elazığ");
            Akademisyenler Nesne4 = new Akademisyenler("bpolat", "456128", "Berna Polat", "Arş. Gör.", "brnpolatt@gmail.com", "Elazığ");
            string beklenen1 = "rdas 785123 Resul Daş Prof. Dr. resuldas@gmail.com Elazığ"; //beklenen değerimiz
            string beklenen2 = "mbaykara 457856 Muhammet Baykara Dr. Öğr. Üyesi muhammetbaykara23@gmail.com Elazığ"; //beklenen değerimiz
            string beklenen3 = "tbalakus 123456 Talha Burak Alakuş Arş. Gör. burak.alakuss@gmail.com Elazığ"; //beklenen değerimiz
            string beklenen4 = "bpolat 456128 Berna Polat Arş. Gör. brnpolatt@gmail.com Elazığ"; //beklenen değerimiz

            Assert.AreEqual(beklenen1, Nesne1.sonuc);
            Assert.AreEqual(beklenen2, Nesne2.sonuc);
            Assert.AreEqual(beklenen3, Nesne3.sonuc);
            Assert.AreEqual(beklenen4, Nesne4.sonuc);
        }


        public void TestMethod1()
        {

        }
    }
}
