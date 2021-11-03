using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YazilimKaliteTest;

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
            Uyg1.Akademisyenler akd = new Uyg1.Akademisyenler("a", "b", "c", "d", "e", "f");
            string beklenen = "a b c d e f"; //beklenen değerimizi bu şekilde belirttik
            Assert.AreEqual(beklenen, akd.sonuc);
        }


        public void TestMethod1()
        {

        }
    }
}
