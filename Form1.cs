namespace Exemplo_Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txbNumero.Text);
            if (num < 0)
                MessageBox.Show("INFORMOU NEGATIVO");
            else
                MessageBox.Show("INFORMOU POSITIVO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txbNome.Text;
            MessageBox.Show("Olá " + nome);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txbNome.Text;
            MessageBox.Show("Olá " + nome);

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txbNumero.Text);
            if (num < 0)
                MessageBox.Show("INFORMOU NEGATIVO");
            else
                MessageBox.Show("INFORMOU POSITIVO");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbNumero.Text = "";
        }
    }
}