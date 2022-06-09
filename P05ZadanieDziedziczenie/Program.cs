using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Plik p = new Plik();

            Plik[] pliki = new Plik[]
            {
                new PlikCSV(){ Zawartosc = "ala ma kota", Sciezka=@"c:\dane\p1"},
                new PlikHTML(){ Zawartosc = "ala ma kota", Sciezka=@"c:\dane\p1"},
                new PlikSQL(){ Zawartosc = "ala ma kota", Sciezka=@"c:\dane\p1"}
            };


            foreach (var p in pliki)
                p.Zapisz();

        }
    }
}
