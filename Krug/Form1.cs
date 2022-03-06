using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Krug krug = new Krug();
                double r = krug.Radius;
                r= Double.Parse(textBox1.Text);
                double b = krug.RasPlo(r);
                textBox2.Text =""+ b ;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Введите значения заново!");
               
            }
        }
    }
}
