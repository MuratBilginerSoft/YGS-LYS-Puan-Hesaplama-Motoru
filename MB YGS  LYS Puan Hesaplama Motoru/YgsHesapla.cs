using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MB_YGS__LYS_Puan_Hesaplama_Motoru
{
    public partial class YgsHesapla : Form
    {
        #region Metodlar

        public void texttamamla()
        {
            foreach (Control nesne in groupBox1.Controls)
            {
                if (nesne is TextBox)
                {
                    if (string.IsNullOrEmpty(nesne.Text))
                    {
                        nesne.Text = "0";
                    }
                }
            }
        }


        public void değeral()
        {
            t = double.Parse(textBox1.Text);
            s = double.Parse(textBox2.Text);
            m = double.Parse(textBox3.Text);
            f = double.Parse(textBox4.Text);
        }

        public void temizle(Control x)
        {
            foreach (Control nesne2 in x.Controls)
            {
                if (nesne2 is TextBox)
                {
                    nesne2.Text = "";
                }
            }
        
        }
        #endregion

        #region Değişkenler

        double t, s, m, f,d,ygs1,ygs2,ygs3,ygs4,ygs5,ygs6;

        #endregion

        public YgsHesapla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            texttamamla();
            değeral();
           
            ygs1 = 100.160 + (t * 1.999) + (s * 1) + (m * 3.998) + (f * 2.999);
            ygs2 = 100.160 + (t * 1.999) + (s * 1) + (m * 2.999) + (f * 3.998);
            ygs3 = 100.160 + (t * 3.998) + (s * 2.999) + (m * 1.999) + (f * 1);
            ygs4 = 100.160 + (t * 2.999) + (s * 3.998) + (m * 1.999) + (f * 1);
            ygs5 = 100.120 + (t * 3.699) + (s * 1.999) + (m * 3.299) + (f * 1);
            ygs6 = 100.120 + (t * 3.299) + (s * 1) + (m * 3.699) + (f * 1.999);

            textBox6.Text = ygs1.ToString();
            textBox7.Text = ygs2.ToString();
            textBox8.Text = ygs3.ToString();
            textBox9.Text = ygs4.ToString();
            textBox10.Text = ygs5.ToString();
            textBox11.Text = ygs6.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texttamamla();
            değeral();
            d = double.Parse(textBox5.Text);

            ygs1 = 100.160 + (t * 1.999) + (s * 1) + (m * 3.998) + (f * 2.999) + (d * 0.6);
            ygs2 = 100.160 + (t * 1.999) + (s * 1) + (m * 2.999) + (f * 3.998) + (d * 0.6);
            ygs3 = 100.160 + (t * 3.998) + (s * 2.999) + (m * 1.999) + (f * 1) + (d * 0.6);
            ygs4 = 100.160 + (t * 2.999) + (s * 3.998) + (m * 1.999) + (f * 1) + (d * 0.6);
            ygs5 = 100.120 + (t * 3.699) + (s * 1.999) + (m * 3.299) + (f * 1) + (d * 0.6);
            ygs6 = 100.120 + (t * 3.299) + (s * 1) + (m * 3.699) + (f * 1.999) + (d * 0.6);

            textBox12.Text = ygs1.ToString();
            textBox13.Text = ygs2.ToString();
            textBox14.Text = ygs3.ToString();
            textBox15.Text = ygs4.ToString();
            textBox16.Text = ygs5.ToString();
            textBox17.Text = ygs6.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle(groupBox1);
            temizle(groupBox2);
            temizle(groupBox3);
        }

        private void YgsHesapla_Load(object sender, EventArgs e)
        {

        }
    }
}
