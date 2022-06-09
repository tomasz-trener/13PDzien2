using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class PlikCSV : Plik
    {
        public PlikCSV()
        {
            rozszerzenie = ".csv";
        }
        public override void Zapisz()
        {
            Zawartosc = Zawartosc.Replace(" ", ";");
            base.Zapisz();
        }
    }
}
