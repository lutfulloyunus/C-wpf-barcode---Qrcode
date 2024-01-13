using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static Barcode_wpf.ProductUserControl;

namespace Barcode_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>();
            productsListBox.ItemsSource = Products;
           

            // Test maqsadida ba'zi mahsulotlar qo'shish
            Products.Add(new Product { Name = "Telefon", Price = 500, Barcode = "123456789" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
            Products.Add(new Product { Name = "Kompyuter", Price = 1200, Barcode = "987654321" });
        }

       
    }
}
