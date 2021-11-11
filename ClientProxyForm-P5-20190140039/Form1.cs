using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_20190140039
{
    public partial class Form1 : Form
    {
        ServiceReference2.MatematikaClient obj = new ServiceReference2.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hTambah = obj.Tambah(angka1, angka2);
            double hKurang = obj.Kurang(angka1, angka2);
            double hKali = obj.Kali(angka1, angka2);
            double hBagi = obj.Bagi(angka1, angka2);

            lTambah.Text = hTambah.ToString();
            lKurang.Text = hKurang.ToString();
            lKali.Text = hKali.ToString();
            lBagi.Text = hBagi.ToString();
        }
    }
}
