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
    public partial class Form1 : Form
    {
        #region Tanımlamalar

        YgsHesapla ygshesapla = new YgsHesapla();
        LysHesapla lyshesapla = new LysHesapla();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ygshesapla.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lyshesapla.ShowDialog();
            this.Show();
        }
    }
}
