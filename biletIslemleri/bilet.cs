using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletIslemleri
{
    class bilet
    {
        public int koltuksay, boskoltuk, bakiye;
        public bool iptalindirim, satindirim;
        public void biletsat()
        {
            if (iptalindirim==true)
            {
                bakiye = bakiye + 25;
                koltuksay = koltuksay + 1;
            }
            else
            {
                bakiye = bakiye + 50;
                koltuksay = koltuksay - 1;
            }
            
        }
        public void iptalbilet()
        {
            if (iptalindirim == true)
            {
                bakiye = bakiye - 25;
                koltuksay = koltuksay + 1;
            }
            else
            {
                bakiye = bakiye - 50;
                koltuksay = koltuksay + 1;
            }

        }
        public void boskoltuksorgula()
        {
            System.Windows.Forms.MessageBox.Show(koltuksay.ToString());
        }
        public void bakiyesorgula()
        {
            System.Windows.Forms.MessageBox.Show(bakiye.ToString());
        }




    }
}
