using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class PlikSQL : Plik
    {
        public PlikSQL()
        {
            rozszerzenie = ".sql";
        }
        public override void Zapisz()
        {
            Zawartosc = $"SELECT * from {Zawartosc}";
            base.Zapisz();

        }
    }
}
