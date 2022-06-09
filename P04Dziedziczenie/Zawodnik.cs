using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Zawodnik : Czlowiek
    {
        public int NrNaKoszulce;

        public override string PrzedstawSie()
        {
            return "Hej, jestem " + Imie + " " + Nazwisko;
        }
    }
}
