using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace KalkulatorTestowanie
{
    [TestFixture]

    class Testy
    {
        Kalkulator _cal;

        [SetUp]
        
        public void SetUp()
        {
            _cal = new Kalkulator();
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _cal = null;
        }

        [TestCase(2, 2, 4)]
        [TestCase(20, 50, 70)]
        [TestCase(10.99, 20.01, 31)]
        [TestCase(-8, -2, -10)]
        public void TestDodawania(double PierwszaLiczba, double DrugaLiczba, double wynik)
        {
            Assert.AreEqual(wynik, _cal.Dodaj(PierwszaLiczba,DrugaLiczba));
        }
        [TestCase(2, 2, 0)]
        [TestCase(20, 50, -30)]
        [TestCase(20.5, 10, 10.5)]
        [TestCase(-8, -2, -6)]
        public void TestOdejmowanie(double PierwszaLiczba, double DrugaLiczba, double wynik)
        {
            Assert.AreEqual(wynik, _cal.Odejmij(PierwszaLiczba, DrugaLiczba));
        }
        [TestCase(2, 2, 4)]
        [TestCase(20, 50, 1000)]
        [TestCase(20.5, 10, 205)]
        [TestCase(-8, -2, 16)]
        public void TestMnozenie(double PierwszaLiczba, double DrugaLiczba, double wynik)
        {
            Assert.AreEqual(wynik, _cal.Pomnóż(PierwszaLiczba, DrugaLiczba));
        }
        [TestCase(2, 2, 1)]
        [TestCase(20, 50, 0.4)]
        [TestCase(20.5, 10, 2.05)]
        [TestCase(-8, -2, 4)]
        public void TestDzielenie(double PierwszaLiczba, double DrugaLiczba, double wynik)
        {
            Assert.AreEqual(wynik, _cal.Podziel(PierwszaLiczba, DrugaLiczba));
        }
        [TestCase(2, 2, 4)]
        [TestCase(2, 10, 1024)]
        [TestCase(4.5, 3, 91.125)]
        [TestCase(8, 11, 8589934592)]
        public void TestPotega(double PierwszaLiczba, double DrugaLiczba, double wynik)
        {
            Assert.AreEqual(wynik, _cal.DoPotegi(PierwszaLiczba, DrugaLiczba));
        }
        [TestCase(4, 2)]
        [TestCase(1024,32)]
        [TestCase(25,5)]
        [TestCase(121,11)]
        public void TestPierwiastek(double Liczba, double wynik)
        {
            Assert.AreEqual(wynik, _cal.Pierwiastek(Liczba));
        }
    }
    

}
