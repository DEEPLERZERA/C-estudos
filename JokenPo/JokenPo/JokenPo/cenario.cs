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
            Forms1 batatinha = new Forms1();
            batatinha.textPontoPlayer.Text = textPontosPlayerCe.Text;
            batatinha.textPontoEnemy.Text = textPontosCompCe.Text;
            batatinha.textPontoEmpate.Text = textPontosEmpateCe.Text;
            int.TryParse(textPontosPlayerCe.Text, out batatinha.pontoPlayer);
            int.TryParse(textPontosCompCe.Text, out batatinha.pontoComp);
            int.TryParse(textPontosEmpateCe.Text, out batatinha.pontoEmpate);
            this.Hide();
            batatinha.Show();
        }
    }
}
