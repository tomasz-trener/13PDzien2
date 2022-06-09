using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08IntrefejsyWybudowane
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] liczby = { 3, 6, 2 };

            Array.Sort(liczby);

            Console.WriteLine(String.Join(" ",liczby));

            Console.WriteLine("------------");

            Zawodnik[] zawodnicy =
            {
                new Zawodnik() { Imie = "jan"},
                new Zawodnik() { Imie ="adam"}
            };

            Array.Sort(zawodnicy);

            zawodnicy.ToList()
                .ForEach(x => Console.WriteLine(x.Imie));
           
 

            Console.ReadKey();



        }
    }
}
