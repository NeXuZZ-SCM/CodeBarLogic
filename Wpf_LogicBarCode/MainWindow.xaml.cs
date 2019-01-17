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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZXing;

namespace Wpf_LogicBarCode
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string ERROR_EMPTY = "";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.CODE_128;

                var imagen = br.Write(txt_Code.Text);
                img_barCode.Source = ConvertBitmapToBitmapImage.Convert(imagen);


                BarcodeWriter qr = new BarcodeWriter();
                qr.Format = BarcodeFormat.QR_CODE;
                qr.Options.Margin = 0;

                var imagenQR = qr.Write(txt_Code.Text);
                img_QR.Source = ConvertBitmapToBitmapImage.Convert(imagenQR);
            }
            catch (System.ArgumentException ex)
            {
                txt_Code.Text = ERROR_EMPTY;
                img_barCode.Source = null;
                img_QR.Source = null;
            }

        }
    }
}
