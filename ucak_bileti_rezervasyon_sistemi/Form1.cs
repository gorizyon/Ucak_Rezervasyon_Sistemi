using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_bileti_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ad ve Soyad : " + maskedTextBox2.Text + " | Tc : " + maskedTextBox3.Text + " | Telefon : " + maskedTextBox4.Text + " | Nereden : " + comboBox1.Text + " | Nereye : " + comboBox2.Text + " | Tarih : " + dateTimePicker1.Text + " | Saat : " + maskedTextBox1.Text);
            MessageBox.Show("Yolcu Kayıdı Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = (comboBox1.Text);
            comboBox1.Text = (comboBox2.Text);
            comboBox2.Text = (label9.Text);

        }
    }
}
