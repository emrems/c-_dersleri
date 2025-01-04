using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gunler.Items.Add("pazartesi");
            gunler.Items.Add("salı");
        }

        private void btn_gunSec_Click(object sender, EventArgs e)
        {
            string secilen = gunler.SelectedItem.ToString();
            MessageBox.Show("seçtiğiniz gün" + secilen);
        }
    }
}
