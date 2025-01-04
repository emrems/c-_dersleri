using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string gelen_deger = txt_girilen.Text;
            listBox1.Items.Add(gelen_deger);
            txt_girilen.Text = "";
        }

        private void sil_Click(object sender, EventArgs e)
        {
            
            string secilen_deger = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(secilen_deger);
        }

        private void count_bul_Click(object sender, EventArgs e)
        {
            int toplam = listBox1.Items.Count;
            MessageBox.Show("toplam değer" + toplam);
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
