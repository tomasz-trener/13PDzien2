using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek()
            {
                Imie = "Marcin",
                Nazwisko = "Marcinski"
            };

            Zawodnik z = new Zawodnik()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski"
            };

            Trener t = new Trener()
            {
                Imie = "Adam",
                Nazwisko = "Nowak"
            };


            Czlowiek c1 = z;
            Czlowiek c2 = t;

            Console.WriteLine(c.PrzedstawSie());
            Console.WriteLine(c1.PrzedstawSie());
            Console.WriteLine(c2.PrzedstawSie());


            ((Zawodnik)c1).NrNaKoszulce = 4;

            Zawodnik zmiennaPomocniczna = (Zawodnik)c1;
            zmiennaPomocniczna.NrNaKoszulce = 5;



            (c1 as Zawodnik).NrNaKoszulce = 7;

            Zawodnik zmienaPomocnicza2 = c1 as Zawodnik;
            zmienaPomocnicza2.NrNaKoszulce = 5;

            Console.WriteLine("----------------------");
            Czlowiek[] osoby = new Czlowiek[] { c1, c2 };

            //foreach (var o in osoby)
            //{
            //    if (o is Zawodnik)
            //        Console.WriteLine(((Zawodnik)o).PrzedstawSie());
            //    else if (o is Trener)
            //        Console.WriteLine(((Trener)o).PrzedstawSie());
            //}

            foreach (var o in osoby)
                Console.WriteLine(o.PrzedstawSie());






            Console.ReadKey();



        }
    }
}
