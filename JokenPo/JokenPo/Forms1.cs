namespace JokenPo
{
    public partial class Forms1 : Form
    {
        int pontoPlayer , pontoComp , pontoEmpate;
        int pontoPlayerControle, pontoCompControle, pontoEmpateControle;
        public Forms1()
        {
            InitializeComponent();

    }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            int jogo;

            // this.Hide();
            cenario cenario = new cenario();
            cenario.Show();
            


            if (rdoPedra.Checked)
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
                        pontoEmpate++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        textPontoEmpate.Text = pontoEmpate.ToString();
                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.userwins.Show();
                        pontoPlayer++;
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        textPontoPlayer.Text = pontoPlayer.ToString();







                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.pcwins.Show();
                        pontoComp++;
                        cenario.textPontosCompCe.Text = pontoComp.ToString();
                        textPontoEnemy.Text = pontoComp.ToString();
                    }
                    break;
                case (2):
                    cenario.pctPapelcomp.Show();
                    if (rdoPedra.Checked)
                    {
                        cenario.pcwins.Show();
                        pontoComp++;
                        cenario.textPontosCompCe.Text = pontoComp.ToString();
                        textPontoEnemy.Text = pontoComp.ToString();
                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.empate.Show();
                        pontoEmpate++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        textPontoEmpate.Text = pontoEmpate.ToString();
                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.userwins.Show();
                        pontoPlayer++;
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        textPontoPlayer.Text = pontoPlayer.ToString();



                    }
                    break;
                case (3):
                    cenario.pctTesouracomp.Show();
                    if (rdoPedra.Checked)
                    {
                        cenario.userwins.Show();
                        pontoPlayer++;
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        textPontoPlayer.Text = pontoPlayer.ToString();




                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.pcwins.Show();
                        pontoComp++;
                        cenario.textPontosCompCe.Text = pontoComp.ToString();
                        textPontoEnemy.Text = pontoComp.ToString();
                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.empate.Show();
                        pontoEmpate++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        textPontoEmpate.Text = pontoEmpate.ToString();
                    }
                    break;
              
            }
       

            

                    

                

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pontoPlayer > pontoComp)
            {
                MessageBox.Show("Você venceu!");
            }
            if (pontoPlayer < pontoComp)
            {
                MessageBox.Show("Você perdeu! :(");
            }
            if (pontoPlayer == pontoComp)
            {
                MessageBox.Show("Você empatou!");
            }
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creditos Creditos = new Creditos();
            Creditos.Show();
        }

        private void textpontuacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

 /* class ponto
{
    private int _pontoPlayer, _pontoEnemy;
    public int getPontoPlayer()
    {
        return this._pontoPlayer;
    }
    public void setPontoPlayer(int pontoPlayer)
    {
        this._pontoPlayer = pontoPlayer;
    }
    public void ganhar()
    {
        int pontoPlayer = this.setPontoPlayer();
    }

    
}
        */
        