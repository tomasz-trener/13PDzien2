using Bogus;
using P02AplikacjaWPF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaWPF.FeedData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            //Zawodnik przykaldowy = new Zawodnik()
            //{
            //    imie = "Ola",
            //    nazwisko = "Kowalska"
            //};
            //Zawodnik przykaldowy = new Zawodnik();
            //przykaldowy.imie = "Ola";
            //przykaldowy.nazwisko = "Kowalska";

            var faker = new Faker<Zawodnik>("pl")
                .RuleFor(x => x.imie, f => f.Name.FirstName())
                .RuleFor(x => x.nazwisko, f => f.Name.LastName())
                .RuleFor(x => x.kraj, f => f.Address.Country())
                .RuleFor(x => x.dataUr, f => f.Date.Past())
                .RuleFor(x => x.wzrost, f => f.Random.Decimal(150, 200))
                .RuleFor(x => x.waga, f => f.Random.Int(50, 100));


            zr.AddData(faker.Generate(100).ToArray());
        }
    }
}
