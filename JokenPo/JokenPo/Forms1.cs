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
        }
    }
}