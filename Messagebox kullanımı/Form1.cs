using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messagebox_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
           
            DialogResult sonuc = MessageBox.Show("çıkış yapmak istediğinize emin misiniz", "bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                label1.Text = "çıkış yapılıyor";
            }
            else if (sonuc == DialogResult.No) 
            {
                label1.Text = "çıkış yapılamadı";
            }
        }
    }
}
