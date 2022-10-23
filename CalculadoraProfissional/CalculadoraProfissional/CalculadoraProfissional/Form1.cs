using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculadoraProfissional
{
    public partial class Form1 : Form
    {
        public float x = 0, y = 0, r = 0;
        public string sinal = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox3.Text);
            textBox3.Text = "";
            sinal = "/";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            int y = int.Parse(textBox3.Text);
            if(sinal == "+")
            {
                r = x + y;
            } else if(sinal == "*")
            {
                r = x * y;
            } else if(sinal == "-")
            {
                r = x - y;
            } else if(sinal == "/")
            {
                r = x / y;
            } else if(sinal == "%")
            {
                r = (x/100) * y;
            }

            textBox3.Text = r.ToString();
            
            
            
            
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox3.Text);
            textBox3.Text = "";
            sinal = "+";
            
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox3.Text += 0.ToString();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox3.Text += 1.ToString();
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox3.Text += 2.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox3.Text += 3.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox3.Text += 4.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox3.Text += 5.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox3.Text += 6.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox3.Text += 7.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox3.Text += 8.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox3.Text += 9.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox3.Text);
            textBox3.Text = "";
            sinal = "-";
        }

        private void btnporcentagem_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox3.Text);
            textBox3.Text = "";
            sinal = "%";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            x = float.Parse(textBox3.Text);
            textBox3.Text = "";
            sinal = "*";

        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            textBox3.Text += ",";
        }
    }
}
