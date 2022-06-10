using P02AplikacjaWPF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaWPF.ViewModel
{
    internal class MainWindowViewModel
    {
       public List<ZawodnikViewModel> ZawodnicyData { get ; set; }

        public MainWindowViewModel()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var data = zr.GetData();

            ZawodnicyData = data
                .Select(x => new ZawodnikViewModel(x)).ToList();
        }
    }
}
