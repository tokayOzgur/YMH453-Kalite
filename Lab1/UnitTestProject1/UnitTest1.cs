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

        [TestMethod]
        public void TestAkad()
        {
            Uyg1.Akademisyenler klas = new Uyg1.Akademisyenler("a", "b", "c", "d", "e", "f");
            Assert.AreEqual(klas, "a", "b", "c", "d", "e", "f");
        }


        public void TestMethod1()
        {

        }
    }
}
