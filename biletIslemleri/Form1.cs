using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bilet b = new bilet();

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            b.koltuksay = int.Parse(txtkoltuksay.Text);
            b.boskoltuk = b.boskoltuk + b.koltuksay;
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            b.biletsat();
            if (rdbSatİndirim.Checked==true)
            {
                b.satindirim = true;
            }
            else
            {
                b.satindirim = false;
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            b.iptalbilet();
            if (rdbİptalİndirim.Checked==true)
            {
                b.iptalindirim = true;
            }
            else
            {
                b.iptalindirim = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(b.boskoltuk.ToString());
            b.boskoltuksorgula();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            b.bakiyesorgula();
        }
    }
}
