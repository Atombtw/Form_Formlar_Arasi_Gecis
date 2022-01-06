using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Formlar_Arası_Geçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            Form1 b = new Form1();
            a.label4.Text = textBox1.Text;

            if (Convert.ToInt32(textBox2.Text) > 100)
            {
                MessageBox.Show("100'den yüksek değer giremezsiniz!");
            }
            else if (Convert.ToInt32(textBox3.Text) > 100)
            {
                MessageBox.Show("100'den yüksek değer giremezsiniz!");
            }
            else if (Convert.ToInt32(textBox4.Text) > 100)
            {
                textBox4.Text = ("100'den yüksek değer giremezsiniz!");
            }
            else
            {
                double s1, s2, s3;
                s1 = Convert.ToDouble(textBox2.Text);
                s2 = Convert.ToDouble(textBox3.Text);
                s3 = Convert.ToDouble(textBox4.Text);
                double ort = (s1 + s2 + s3) / 3;
                a.label5.Text = Convert.ToString(ort);
                if (ort >= 50)
                {
                    string g = "Geçti";
                    a.label6.Text = g;
                }
                else
                {
                    string k = "Kaldı";
                    a.label6.Text = k;
                }
                a.ShowDialog();
                b.Close(); 
            }
        }
    }
}
