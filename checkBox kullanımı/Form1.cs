using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            if (checkbox_cay.Checked)
            {
                toplam += 2;
            }

            if (checkbox_su.Checked)
            {
                toplam += 3;
            }

            if (checkbox_gazoz.Checked)
            {
                toplam += 4;
            }

            if(checkbox_kahve.Checked)
            {
                toplam += 10;
            }

            label_sonuc.Text = toplam.ToString();
        }
    }
}
