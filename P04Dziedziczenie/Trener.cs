using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Trener : Czlowiek
    {
        public int LiczbaGwizdkow;

        public new string PrzedstawSie()
        {
            return "Dzien dobry, jestem trenerem " + Imie + " " + Nazwisko;
        }
    }
}
