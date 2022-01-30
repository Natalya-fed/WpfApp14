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
using System.Collections.ObjectModel;

namespace WpfApp14
{

    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
                {
                    new Product { NameProduct = "Колбаса", PriceProduct = 125, ImageProduct = @"Data\колбаса.jpg", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Торт", PriceProduct = 250, ImageProduct = @"Data\торт.jpg", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Наушники", PriceProduct = 3999, ImageProduct = @"Data\наушники.jpg", CategoryProduct = Categories.Appliances },
                    new Product { NameProduct = "Стиральная машина", PriceProduct = 119999, ImageProduct = @"Data\стир. маш.jpg", CategoryProduct = Categories.Appliances }
                };

            listBox.ItemsSource = products;
        }
    }

}
