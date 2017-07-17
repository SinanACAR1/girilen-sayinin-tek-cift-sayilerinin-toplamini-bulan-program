using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle() 
        {
            textBox1.Clear();
          
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tektoplam = 0;
                int çifttoplam = 0;
                int sayı;
                sayı = Convert.ToInt32(textBox1.Text);
                temizle();
                if (sayı % 2 == 0)
                {
                    çifttoplam = çifttoplam + sayı;
                    lblçiftsayılar.Text = çifttoplam.ToString();
                }
                if (sayı % 1 == 0)
                {
                    tektoplam = tektoplam + sayı;
                    lblteksayılar.Text = tektoplam.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Sayı giriniz..");
            }
        }
    }
}
