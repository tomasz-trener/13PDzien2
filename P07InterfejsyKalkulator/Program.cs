using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InterfejsyKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SystemKalkulator sk = new SystemKalkulator();

            sk.WykonajOperacje(new ModulDodawania(), 3, 4);
        }
    }
}
