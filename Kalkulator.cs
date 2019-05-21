using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorTestowanie
{
   public class Kalkulator
    {
        public double Dodaj(double PierwszaLiczba, double DrugaLiczba)
        {
            return PierwszaLiczba + DrugaLiczba;
        }
        public double Odejmij(double PierwszaLiczba, double DrugaLiczba)
        {
            return PierwszaLiczba - DrugaLiczba;
        }
        public double Pomnóż(double PierwszaLiczba, double DrugaLiczba)
        {
            return PierwszaLiczba * DrugaLiczba;
        }
        public double Podziel(double PierwszaLiczba, double DrugaLiczba)
        {
            return PierwszaLiczba / DrugaLiczba;
        }
        public double DoPotegi(double Podstawa, double Wykladnik)
        {
            return Math.Pow(Podstawa, Wykladnik);
        }
        public double Pierwiastek(double Liczba)
        {
            return Math.Sqrt(Liczba);
        }
    }
}
