using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matematik;

namespace dll_oluşturma_ve_kullanma
{
    public partial class Form1 : Form
    {
        MatematikIslemleri mat_islem = new MatematikIslemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            int ilk_deger = Convert.ToInt32(txt_ilk.Text);
            int ikinci_deger = Convert.ToInt32(txt_iki.Text);
            int toplam = mat_islem.Topla(ilk_deger, ikinci_deger);
            sonuc.Text = toplam.ToString();

        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            int ilk_deger = Convert.ToInt32(txt_ilk.Text);
            int ikinci_deger = Convert.ToInt32(txt_iki.Text);
            int toplam = mat_islem.Fark(ilk_deger, ikinci_deger);
            sonuc.Text = toplam.ToString();

        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            int ilk_deger = Convert.ToInt32(txt_ilk.Text);
            int ikinci_deger = Convert.ToInt32(txt_iki.Text);
            int toplam = mat_islem.Carp(ilk_deger, ikinci_deger);
            sonuc.Text = toplam.ToString();

        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            int ilk_deger = Convert.ToInt32(txt_ilk.Text);
            int ikinci_deger = Convert.ToInt32(txt_iki.Text);
            int toplam = mat_islem.Bol(ilk_deger, ikinci_deger);
            sonuc.Text = toplam.ToString();
        }
    }
}
