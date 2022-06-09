using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class PlikHTML : Plik
    {
        public PlikHTML()
        {
            rozszerzenie = ".html";
        }
        public override void Zapisz()
        {
            szablon = "<html><body><p>{0}</p></body></html>";
            Zawartosc = string.Format(szablon, Zawartosc);
            base.Zapisz();
        }
    }
}
