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

namespace Barcode_wpf
{
    /// <summary>
    /// Логика взаимодействия для ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }

        public Product Product
        {
            get { return (Product)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }

        public static readonly DependencyProperty ProductProperty =
            DependencyProperty.Register("Product", typeof(Product), typeof(ProductUserControl), new PropertyMetadata(null));

        private void PrintBarcode_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Shtrix kod chiqarildi: " + Product.Barcode);
        }

        private void PrintBarcode_Click1(object sender, RoutedEventArgs e)
        {
           /* BarcodeApp sl =new BarcodeApp();
            sl.ShowDialog();*/
           QRCodeApp sl =new QRCodeApp();
            sl.ShowDialog();
        }
    }
}
