namespace cadastrousuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastrorecebido cadastrorecebido = new cadastrorecebido();
            cadastrorecebido.txtNome.Text = txtNome.Text;
            cadastrorecebido.txtData.Text = txtData.Text;
            cadastrorecebido.txtSexo.Text = txtSexo.Text;
            cadastrorecebido.Show();
            this.Hide();
        }
    }
}