using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ZXing;
//La libreria ZXing es una .dll externa  ^_^ 

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.CODE_128;
                Bitmap bm = new Bitmap(br.Write(textBox1.Text), 200, 100);
                pictureBox1.Image = bm;
                label1.Text = textBox1.Text;
            }
            else
            {
                label1.Text = "";
                pictureBox1.Image = null;
            }
            
        }
    }
}
