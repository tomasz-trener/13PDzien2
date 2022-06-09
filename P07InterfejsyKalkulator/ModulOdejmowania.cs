using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InterfejsyKalkulator
{
    internal class ModulOdejmowania : IUmiajcyLiczyc
    {
        public int Policz(int a, int b)
        {
            return a - b;
        }
    }
}
