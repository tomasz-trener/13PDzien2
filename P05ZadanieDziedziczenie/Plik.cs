using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal abstract class Plik
    {
        public string Zawartosc;
        public string Autor;
        public string Sciezka;
        private protected string szablon;
        private protected string rozszerzenie;

        public virtual void Zapisz() 
        {
            File.WriteAllText(Sciezka + rozszerzenie, Zawartosc);
        }
    }
}
