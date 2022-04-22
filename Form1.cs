using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareSolution
{
    public partial class Form1 : Form
    {
        private Controller __controller;
        public Form1(Controller controller)
        {
            InitializeComponent();
            __controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double c = Double.Parse(textBox3.Text);

            __controller.solution(a, b, c);
        }


        public void setResult(double x1, double x2)
        {
            textBox4.Text = x1 + " " + x2;
        }
    }
}
