using P02AplikacjaWPF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaWPF.ViewModel
{
    internal class ZawodnikViewModel
    {

        private Zawodnik zawodnikDb;

        public ZawodnikViewModel(Zawodnik zawodnikDb)
        {
            this.zawodnikDb = zawodnikDb;
        }

        public string Imie
        {
            get { return zawodnikDb.imie; }
            set { zawodnikDb.imie = value; }
        }

        public string Nazwisko
        {
            get { return zawodnikDb.nazwisko; }
            set { zawodnikDb.nazwisko = value; }
        }

        public string Kraj
        {
            get { return zawodnikDb.kraj; }
            set { zawodnikDb.kraj = value; }
        }

        public DateTime? DataUr
        {
            get { return zawodnikDb.dataUr; }
            set { zawodnikDb.dataUr = value; }
        }

        public int? Waga
        {
            get { return zawodnikDb.waga; }
            set { zawodnikDb.waga = value; }
        }

        public decimal? Wzrost
        {
            get { return zawodnikDb.wzrost; }
            set { zawodnikDb.wzrost = value; }
        }

        public bool WagaWidoczna { get => Waga > 60; }

        public double? BMI { get => Waga/ Math.Pow(Convert.ToDouble(Wzrost)/100,2); }
    }
}