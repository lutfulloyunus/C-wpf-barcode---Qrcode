using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;
using ZXing;


namespace Barcode_wpf
{
    /// <summary>
    /// Логика взаимодействия для BarcodeApp.xaml
    /// </summary>
    public partial class BarcodeApp : Window
    {
        public BarcodeApp()
        {
            InitializeComponent();
            GenerateBarcode("123456789");
        }
        private void GenerateBarcode(string content)
        {
            var barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;
            barcodeWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 100
            };

            var barcodeBitmap = barcodeWriter.Write(content);

            // Bitmap to ImageSource
            var imageSourceConverter = new ImageSourceConverter();
            var imageSource = (System.Windows.Media.ImageSource)imageSourceConverter.ConvertFrom(bitmapToByteArray(barcodeBitmap));

            barcodeImage.Source = imageSource;
        }

        private byte[] bitmapToByteArray(Bitmap bitmap)
        {
            var stream = new System.IO.MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }
    }
}
