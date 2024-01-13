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
    /// Логика взаимодействия для QRCodeApp.xaml
    /// </summary>
    public partial class QRCodeApp : Window
    {
        public QRCodeApp()
        {
            InitializeComponent();
            GenerateQRCode("https://www.example.com");
        }
        private void GenerateQRCode(string content)
        {
            var barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            barcodeWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 300
            };

            var qrCodeBitmap = barcodeWriter.Write(content);

            // Bitmap to ImageSource
            var imageSourceConverter = new ImageSourceConverter();
            var imageSource = (System.Windows.Media.ImageSource)imageSourceConverter.ConvertFrom(bitmapToByteArray(qrCodeBitmap));

            qrCodeImage.Source = imageSource;
        }

        private byte[] bitmapToByteArray(Bitmap bitmap)
        {
            var stream = new System.IO.MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }
    }
}
