using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class cenario : Form
    {
        
        public cenario()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pctPapelcomp_Click(object sender, EventArgs e)
        {

        }

        private void empate_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Forms1 Forms1 = new Forms1();
            Forms1.textPontoPlayer.Text = textPontosPlayerCe.Text;
            Forms1.textPontoEnemy.Text = textPontosCompCe.Text;
            Forms1.textPontoEmpate.Text = textPontosEmpateCe.Text;
            Forms1.Show();
        }
    }
}
