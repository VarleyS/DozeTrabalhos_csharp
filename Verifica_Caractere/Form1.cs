namespace Verifica_Caractere
{
    public partial class Form1 : Form
    {
        char entrada;
        int valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            entrada = Convert.ToChar(txtCaractere.Text);
            valor = Convert.ToInt32(entrada);

            if (valor >= 65 && valor <= 90)
            {
                lblResultado.Text = "String Maiúscula";
            }
            if (valor >= 97 && valor <= 122)
            {
                lblResultado.Text = "String Minúscula";
            }
            if (valor >= 48 && valor <= 57)
            {
                lblResultado.Text = "String Numero";
            }
            if ((valor >= 0 && valor <= 47) || (valor >= 58 && valor <= 64) || (valor >= 91 && valor <= 96) || (valor >= 123 && valor <= 127))
            {
                lblResultado.Text = "Símbolo Especial";
            }
            if (valor >= 127)
            {
                lblResultado.Text = "Caractere Especial";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerifica(object sender, EventArgs e)
        {
            entrada = Convert.ToChar(txtCaractere.Text);
            valor = Convert.ToInt32(entrada);

            if (valor >= 65 && valor <= 90)
            {
                lblResultado.Text = "String Maiúscula";
            }
            if (valor >= 97 && valor <= 122)
            {
                lblResultado.Text = "String Minúscula";
            }
            if (valor >= 48 && valor <= 57)
            {
                lblResultado.Text = "String Numero";
            }
            if ((valor >= 0 && valor <= 47) || (valor >= 58 && valor <= 64) || (valor >= 91 && valor <= 96) || (valor >= 123 && valor <= 127))
            {
                lblResultado.Text = "Símbolo Especial";
            }
            if (valor >= 127)
            {
                lblResultado.Text = "Caractere Especial";
            }
        }
    }
}
