using CarShowRoom.Models;
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

namespace CarShowRoom
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

        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        } 

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Car_Model_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Context())
            {
                context.CarModels.Add(new Cars()
                {
                    CarBrand = "X5",
                    Color = "Red",
                    BodyType = "BMW type",
                    ProducingCountry = "Germany",
                    ProductionYear = new DateTime(1995,03,12),
                    //Price = 78960.1
                });
                context.CarModels.Add(new Cars()
                {
                    CarBrand = "X6",
                    Color = "Black",
                    BodyType = "BMW another type",
                    ProducingCountry = "Germany",
                    ProductionYear = new DateTime(1998, 05, 24),
                    //Price = 123960.1
                });
                context.SaveChanges();
                var carModels = context.CarModels.ToList();
                dataGrid.ItemsSource = carModels;
            } 
           
        }
    }
}
