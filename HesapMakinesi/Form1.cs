using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //yanlışlıkla event açtığımız zaman program hata verir design kısmı çalışmaz.
            //bu nedenle yanlışlıkla açılan eventi silme işlemini componentin properties kısmında ki eventlerden silmek gerek.
        }

        private void button10_Click(object sender, EventArgs e)
        {

            txtGirilenDeger.Text += txt0.Text;
        }

        private void txt1_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text+= txt1.Text;
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt2.Text;
        }

        private void txt3_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt3.Text;
        }

        private void txt4_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt4.Text;
        }

        private void txt5_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt5.Text;
        }

        private void txt6_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt6.Text;
        }

        private void txt7_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt7.Text;
        }

        private void txt8_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt8.Text;
        }

        private void txt9_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += txt9.Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += btnEkle.Text;
        }

        private void btnFark_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text+= btnFark.Text;

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += btnCarp.Text;
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text += btnBol.Text;
        }
    }
}
