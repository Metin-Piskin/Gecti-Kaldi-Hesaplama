using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Geçti_Kaldı_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ad, soyad;
        int vize, final, büt, no, ort, ort1;

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            label6.Visible = false;
            maskedTextBox3.Visible = false;
            button2.Visible = false;
            label18.BackColor = Color.DarkSalmon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ort1 = (vize + büt) / 2;
            büt = Convert.ToInt16(maskedTextBox3.Text);
            label14.Text = büt.ToString();
            label20.Text = ort1.ToString();
            label14.Visible = true;
            label13.Visible = true;
            if (ort1 < 50)
            {
                label18.Text = "Kaldı";
                label18.BackColor = Color.Red;
            }
            if (ort1 >= 50 && ort1 <= 60)
            {
                label18.Text = "D ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort1 > 60 && ort1 <= 70)
            {
                label18.Text = "C ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort1 > 70 && ort1 <= 80)
            {
                label18.Text = "B ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort1 > 80 && ort1 <= 90)
            {
                label18.Text = "A ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort1 > 90 && ort1 <= 100)
            {
                label18.Text = "A++ ile Geçti";
                label18.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            soyad = textBox2.Text;
            no = Convert.ToInt16(textBox3.Text);
            vize = Convert.ToInt16(maskedTextBox1.Text);
            final = Convert.ToInt16(maskedTextBox2.Text);
            ort = (vize + final) / 2;
            label8.Text = ad +" "+ soyad;
            label10.Text = no.ToString();
            label16.Text = vize.ToString();
            label15.Text = final.ToString();
            label20.Text = ort.ToString();
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            button3.Visible = true;
            if (ort < 50)
            {
                
                label18.Text = "Kaldı";
                label6.Visible = true;
                maskedTextBox3.Visible = true;
                button2.Visible = true;
                label18.BackColor = Color.Red;
                

               
            }
            if (ort >= 50 && ort <= 60)
            {
                label18.Text = "D ile Geçti";
                label18.BackColor = Color.Green;
            }
            if(ort > 60 && ort <= 70)
            {
                label18.Text = "C ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort > 70 && ort <= 80)
            {
                label18.Text = "B ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort > 80 && ort <= 90)
            {
                label18.Text = "A ile Geçti";
                label18.BackColor = Color.Green;
            }
            if (ort > 90 && ort <= 100)
            {
                label18.Text = "A++ ile Geçti";
                label18.BackColor = Color.Green;
            }
        }
    }
}
