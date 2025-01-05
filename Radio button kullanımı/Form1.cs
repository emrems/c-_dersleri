using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_button_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet = "";
            ad = name.Text;
            soyad = surname.Text;

            if (erkek.Checked)
            {
                cinsiyet = "erkek";
            }
            else
            {
                cinsiyet = "kadın";
            }

            MessageBox.Show($"isim:{ad} soyisim:{soyad} cinsiyet:{cinsiyet}");
        }
    }
}
