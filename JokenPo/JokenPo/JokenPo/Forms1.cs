namespace JokenPo
{
    public partial class Forms1 : Form
    {
       public int pontoPlayer=0 , pontoComp=0 , pontoEmpate=0;

        
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
                        pontoEmpate++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();
                        cenario.empate.Show();
                        
                        
                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.userwins.Show();
                        pontoPlayer++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();









                    }
                    if (rdoTesoura.Checked)
                    {
                        
                        pontoComp++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();
                        cenario.pcwins.Show();

                    }
                    break;
                case (2):
                    cenario.pctPapelcomp.Show();
                    if (rdoPedra.Checked)
                    {
                        
                        pontoComp++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();

                        cenario.pcwins.Show();


                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.empate.Show();
                        pontoEmpate++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();


                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.userwins.Show();
                        pontoPlayer++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();





                    }
                    break;
                case (3):
                    cenario.pctTesouracomp.Show();
                    if (rdoPedra.Checked)
                    {
                        cenario.userwins.Show();
                        pontoPlayer++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();





                    }
                    if (rdoPapel.Checked)
                    {
                        cenario.pcwins.Show();
                        pontoComp++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();


                    }
                    if (rdoTesoura.Checked)
                    {
                        cenario.empate.Show();
                        pontoEmpate++;
                        cenario.textPontosEmpateCe.Text = pontoEmpate.ToString();
                        cenario.textPontosPlayerCe.Text = pontoPlayer.ToString();
                        cenario.textPontosCompCe.Text = pontoComp.ToString();



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
        