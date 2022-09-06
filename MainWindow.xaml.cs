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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //listbox.ItemsSource = GetCars();
            //mydatagrid.ItemsSource = GetCars();
        }

        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car()
                {
                    Model = "E-200",
                    Vendor = "Mercedes",
                    Year = 2022
                },
                new Car()
                {
                    Model = "Supra",
                    Vendor = "Toyota",
                    Year = 2004
                },
                new Car()
                {
                    Model = "X-Trail",
                    Vendor = "Nissan",
                    Year = 2012
                },
                new Car()
                {
                    Model = "LandRover",
                    Vendor = "RangeRover",
                    Year = 2014
                },
                new Car()
                {
                    Model = "X5",
                    Vendor = "BMW",
                    Year = 2020
                }
            };
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car = listbox.SelectedItem as Car;
            //MessageBox.Show(car.ToString());
            //MessageBox.Show(car.Year.ToString());
        }

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value <= prgbar.Maximum)
        //    {
        //        prgbar.Value += 5;
        //    }
        //}

        //private void down_Click(object sender, RoutedEventArgs e)
        //{
        //    if (prgbar.Value <= prgbar.Maximum)
        //    {
        //        prgbar.Value += 5;
        //    }
        //}
    }
}
