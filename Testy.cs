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
        ///nowy kalkulator przed kazdym testem
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
    }

}
