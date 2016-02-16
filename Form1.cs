using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, r1, x2, y2, r2, sumapromieni, roznicapromieni, d = 0;
            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            r1 = Convert.ToDouble(textBox3.Text);
            x2 = Convert.ToDouble(textBox4.Text);
            y2 = Convert.ToDouble(textBox5.Text);
            r2 = Convert.ToDouble(textBox6.Text);
            d = Math.Sqrt((x1 - x2) * (x1 - x2) * (y1 - y2) * (y1 - y2));
            sumapromieni = r1 + r2;
            roznicapromieni = Math.Abs(r1 - r2);
            if (d > sumapromieni || d < roznicapromieni)
                label11.Text = ("Okręgi nie mają punktów wspólnych");
            else if (d == sumapromieni || d == roznicapromieni)
                label11.Text = ("Okręgi mają jeden punkt wspólny");
            else
                label11.Text = ("Okręgi mają dwa punkty wspólne");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            label11.Text = ("");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
