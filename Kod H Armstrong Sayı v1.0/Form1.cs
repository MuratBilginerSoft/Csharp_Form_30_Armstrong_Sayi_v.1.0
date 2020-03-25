using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kod_H_Armstrong_Sayı_v1._0
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int Sayi;
        double A, Toplam = 0;
        string S1, S2;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnKntrl_Click(object sender, EventArgs e)
        {
            Toplam = 0;
            S1 = MTBSayi.Text;
            Sayi = Convert.ToInt32(MTBSayi.Text);

            foreach (char C in S1)
            {
                S2 = C.ToString();
                A = Convert.ToDouble(S2);
                Toplam += (Math.Pow(A, 3));
            }

            if (Sayi == Toplam)
            {
                LblSonuc.Text = Sayi + " Armstrong Sayıdır";
            }

            else
            {
                LblSonuc.Text = Sayi + " Armstrong Sayı Değildir";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
