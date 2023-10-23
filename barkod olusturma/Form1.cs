using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace barkod_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Code128BarcodeDraw barkod = BarcodeDrawFactory.Code128WithChecksum;

            pictureBox1.Image = barkod.Draw(textBox1.Text, 50);
        }
    }
}
