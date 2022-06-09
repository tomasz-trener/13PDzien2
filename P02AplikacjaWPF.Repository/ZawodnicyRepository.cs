using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaWPF.Repository
{
    public class ZawodnicyRepository
    {
        // CRUD 

        public Zawodnik[] GetData()
        {
            DatabaseZawodnicyDataContext db = new DatabaseZawodnicyDataContext();

            Zawodnik[] zawodnicy= db.Zawodniks.ToArray();

            return zawodnicy;
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }

        public void DeleteData()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// params oznacza, ze moge podac 1, 2 lub dowolna liczbe zawodnikow
        /// po przecinku lub moge po prostu podac całą tablicę zawodnikow 
        /// </summary>
        /// <param name="z"></param>
        public void AddData(params Zawodnik[] z)
        {
            DatabaseZawodnicyDataContext db = new DatabaseZawodnicyDataContext();
            db.Zawodniks.InsertAllOnSubmit(z);
            db.SubmitChanges();
        }
    }
}
