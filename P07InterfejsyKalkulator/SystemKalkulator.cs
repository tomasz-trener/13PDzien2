using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InterfejsyKalkulator
{
    internal class SystemKalkulator
    {
        public void WykonajOperacje(IUmiajcyLiczyc umiajcyLiczyc, int a, int b)
        {
            // zapisac do baazy...

            int wynik = umiajcyLiczyc.Policz(a, b);

            Console.WriteLine(wynik);
        }
    }
}
