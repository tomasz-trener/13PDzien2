using P01AplikacjaWPF.ViewModel;
using P02AplikacjaWPF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P01AplikacjaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {     
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var data= zr.GetData();
           
            var dataVM = data
                .Select(x => new ZawodnikViewModel(x)).ToArray();

            //ZawodnikViewModel[] dataVM2 = new ZawodnikViewModel[data.Length];
            //for (int i = 0; i < data.Length; i++)
            //    dataVM2[i] = new ZawodnikViewModel(data[i]);

            lvData.ItemsSource = dataVM;
        }
    }
}
