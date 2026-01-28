namespace VerificaCaractere
{
    public partial class Form1 : Form
    {
        char entrada;
        int valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            btnVerifica_Click(sender, e);
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            // valida entrada: deve haver exatamente 1 caractere
            if (string.IsNullOrEmpty(txtCaractere.Text) || txtCaractere.Text.Length != 1)
            {
                lblResultado.Text = "Informe um único caractere";
                return;
            }

            entrada = txtCaractere.Text[0];
            valor = (int)entrada;

            if (valor >= 65 && valor <= 90)
            {
                lblResultado.Text = "String Maiúsculo";
                return;
            }
            else if (valor >= 97 && valor <= 122)
            {
                lblResultado.Text = "String Minúsculo";
                return;
            }
            else if (valor >= 48 && valor <= 57)
            {
                lblResultado.Text = "Dígito";
                return;
            }
            else if ((valor >= 0 && valor <= 47) || (valor >= 58 && valor <= 64) ||
                     (valor >= 91 && valor <= 96) || (valor >= 123 && valor <= 127))
            {
                lblResultado.Text = "Símbolo Especial";
                return;
            }
            else // valor > 127
            {
                lblResultado.Text = "Caractere Especial";
            }
        }
    }
}
