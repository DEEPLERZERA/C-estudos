namespace JokenPo
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            int jogo;
            this.Hide();
            cenario cenario = new cenario();
            cenario.Show();
           

            if(rdoPedra.Checked)
            {
                cenario.pctPedra.Show();
            }
            if(rdoPapel.Checked)
            {
                cenario.pctPapel.Show();
            }
            if(rdoTesoura.Checked)
            {
               cenario.pctTesoura.Show();
            }
            Random aleatorio = new Random();
           jogo =  aleatorio.Next(1, 4);
            switch (jogo)
            {

                case (1):
                    cenario.pctPedracomp.Show();
                    if(rdoPedra.Checked)
                    {
                        cenario.empate.Show();
                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.userwins.Show();
                      
                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.pcwins.Show();
                    }
                    break;
                case (2):
                    cenario.pctPapelcomp.Show();
                    if (rdoPedra.Checked)
                    {
                        cenario.pcwins.Show();
                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.empate.Show();
                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.userwins.Show();
                      
                    }
                    break;
                case (3):
                    cenario.pctTesouracomp.Show();
                    if (rdoPedra.Checked)
                    {
                        cenario.userwins.Show();
                       
                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.pcwins.Show();
                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.empate.Show();
                    }
                    break;
              
            }

            

                    

                

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creditos Creditos = new Creditos();
            Creditos.Show();
        }
    }
}