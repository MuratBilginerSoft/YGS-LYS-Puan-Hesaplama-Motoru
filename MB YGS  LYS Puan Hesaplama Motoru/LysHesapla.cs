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
    public partial class LysHesapla : Form
    {
        #region Metodlar

        public void texttamamla(Control y)
        {
            foreach (Control nesne in y.Controls)
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
            m2 = double.Parse(textBox6.Text);
            g = double.Parse(textBox7.Text);
            f2 = double.Parse(textBox8.Text);
            k = double.Parse(textBox9.Text);
            b = double.Parse(textBox10.Text);
            t = double.Parse(textBox11.Text);
            e1 = double.Parse(textBox12.Text);
            c1 = double.Parse(textBox13.Text);
            c2 = double.Parse(textBox14.Text);
            f3 = double.Parse(textBox15.Text);

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

        double t, s, m, f,m2,g,f2,k,b,c1,c2,f3,mf1,mf2,mf3,mf4,tm1,tm2,tm3,ts1,ts2,d,e1;
        

        #endregion


        public LysHesapla()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            texttamamla(groupBox4);
            texttamamla(groupBox5);

            değeral();
            mf1 = 100 + (t * 1.334) + (m * 1.619) + (s * 0.311) + (f * 0.921) + (m2 * 2.732) + (g * 1.439) + (f2 * 1.059) + (k * 0.391) + (b * 0.311);
            mf2 = 99.990 + (t * 1.314) + (m * 1.314) + (s * 0.311) + (f * 1.439) + (m2 * 1.568) + (g * 0.908) + (f2 * 1.469) + (k * 1.253) + (b * 1.253);
            mf3 = 100.010 + (t * 1.311) + (m * 1.311) + (s * 0.798) + (f * 1.311) + (m2 * 1.245) + (g * 0.598) + (f2 * 1.348) + (k * 1.447) + (b * 1.557);
            mf4 = 99.990 + (t * 1.311) + (m * 1.447) + (s * 0.798) + (f * 0.800) + (m2 * 2.200) + (g * 1.311) + (f2 * 1.348) + (k * 0.800) + (b * 0.400);
            tm1 = 100.002 + (t * 1.335) + (m * 1.337) + (s * 0.633) + (f * 0.465) + (m2 * 1.901) + (g * 1.086) + (e1 * 1.582) + (c1 * 1.374);
            tm2 = 100.020 + (t * 1.488) + (m * 1.412) + (s * 0.619) + (f * 0.358) + (m2 * 1.880) + (g * 0.450) + (e1 * 1.890) + (c1 * 1.315);
            tm3 = 99.982 + (t * 1.651) + (m * 1.035) + (s * 0.974) + (f * 0.382) + (m2 * 1.573) + (g * 0.420) + (e1 * 1.961) + (c1 * 1.553);
            ts1 = 101.974 + (c2 * 0.843) + (t * 1.276) + (m * 1.043) + (s * 1.204) + (f * 0.498) + (e1 * 1.534) + (t * 1.534) + (c1 * 0.954) + (f3 * 1.534);
            ts2 = 110.526 + (t * 1.809) + (m * 0.378) + (s * 1.033) + (f * 0.469) + (e1 * 1.966) + (c1 * 0.809) + (c2 * 0.809) + (t * 1.479) + (f3 * 1.125);

            textBox16.Text = mf1.ToString();
            textBox17.Text = mf2.ToString();
            textBox18.Text = mf3.ToString();
            textBox19.Text = mf4.ToString();
            textBox20.Text = tm1.ToString();
            textBox21.Text = tm2.ToString();
            textBox22.Text = tm3.ToString();
            textBox23.Text = ts1.ToString();
            textBox24.Text = ts2.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            texttamamla(groupBox4);
            texttamamla(groupBox5);
            değeral();
            d = double.Parse(textBox5.Text);

            mf1 = 100 + (t * 1.334) + (m * 1.619) + (s * 0.311) + (f * 0.921) + (m2 * 2.732) + (g * 1.439) + (f2 * 1.059) + (k * 0.391) + (b * 0.311) + (d * 0.6);
            mf2 = 99.990 + (t * 1.314) + (m * 1.314) + (s * 0.311) + (f * 1.439) + (m2 * 1.568) + (g * 0.908) + (f2 * 1.469) + (k * 1.253) + (b * 1.253) + (d * 0.6);
            mf3 = 100.010 + (t * 1.311) + (m * 1.311) + (s * 0.798) + (f * 1.311) + (m2 * 1.245) + (g * 0.598) + (f2 * 1.348) + (k * 1.447) + (b * 1.557) + (d * 0.6);
            mf4 = 99.990 + (t * 1.311) + (m * 1.447) + (s * 0.798) + (f * 0.800) + (m2 * 2.200) + (g * 1.311) + (f2 * 1.348) + (k * 0.800) + (b * 0.400) + (d * 0.6);
            tm1 = 100.002 + (t * 1.335) + (m * 1.337) + (s * 0.633) + (f * 0.465) + (m2 * 1.901) + (g * 1.086) + (e1 * 1.582) + (c1 * 1.374) + (d * 0.6);
            tm2 = 100.020 + (t * 1.488) + (m * 1.412) + (s * 0.619) + (f * 0.358) + (m2 * 1.880) + (g * 0.450) + (e1 * 1.890) + (c1 * 1.315) + (d * 0.6);
            tm3 = 99.982 + (t * 1.651) + (m * 1.035) + (s * 0.974) + (f * 0.382) + (m2 * 1.573) + (g * 0.420) + (e1 * 1.961) + (c1 * 1.553) + (d * 0.6);
            ts1 = 101.974 + (c2 * 0.843) + (t * 1.276) + (m * 1.043) + (s * 1.204) + (f * 0.498) + (e1 * 1.534) + (t * 1.534) + (c1 * 0.954) + (f3 * 1.534) + (d * 0.6);
            ts2 = 110.526 + (t * 1.809) + (m * 0.378) + (s * 1.033) + (f * 0.469) + (e1 * 1.966) + (c1 * 0.809) + (c2 * 0.809) + (t * 1.479) + (f3 * 1.125) + (d * 0.6);

            textBox25.Text = mf1.ToString();
            textBox26.Text = mf2.ToString();
            textBox27.Text = mf3.ToString();
            textBox28.Text = mf4.ToString();
            textBox29.Text = tm1.ToString();
            textBox30.Text = tm2.ToString();
            textBox31.Text = tm3.ToString();
            textBox32.Text = ts1.ToString();
            textBox33.Text = ts2.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle(groupBox4);
            temizle(groupBox5);
            temizle(groupBox6);
            temizle(groupBox7);

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
