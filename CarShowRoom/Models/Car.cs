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

namespace CarShowRoom.Models
{
    public class Car
    { 
        public int Id { get; set; } 
        public string CarBrand { get; set; }
        public string Color { get; set; }
        public string ProducingCountry { get; set; } 
        public DateTime ProductionYear { get; set; }
        public string BodyType { get; set; } 
        public double Price { get; set; }
    }
}
