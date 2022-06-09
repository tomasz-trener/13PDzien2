using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08IntrefejsyWybudowane
{
    internal class Zawodnik : IComparable
    {
        public string Imie;
        public string Nazwisko;

        public int CompareTo(object obj)
        {
            return Imie.Length - ((Zawodnik)obj).Imie.Length;


        }
    }
}
