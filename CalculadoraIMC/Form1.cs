namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // L� os valores de peso e altura
                float peso = float.Parse(txtPeso.Text);
                float altura = float.Parse(txtAltura.Text);

                // Valida se os valores s�o positivos
                if (peso > 0 && altura > 0)
                {
                    // Calcula o IMC
                    float imc = peso / (altura * altura);

                    // Formata o resultado para 2 casas decimais
                    string resultadoIMC = imc.ToString("F2");

                    // Interpreta o valor do IMC
                    string interpretacao = InterpretarIMC(imc);

                    // Exibe o resultado no Label
                    lblResultado.Text = $"Seu IMC � {resultadoIMC}. {interpretacao}";
                }
                else
                {
                    MessageBox.Show("Peso e altura devem ser valores positivos.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores v�lidos para peso e altura.");
            }
        }

        // Fun��o para interpretar o valor do IMC
        private string InterpretarIMC(float imc)
        {
            if (imc < 18.5)
                return "Voc� est� abaixo do peso.";
            else if (imc >= 18.5 && imc < 24.9)
                return "Voc� est� com peso normal.";
            else if (imc >= 25 && imc < 29.9)
                return "Voc� est� com sobrepeso.";
            else
                return "Voc� est� com obesidade.";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada e o label de resultado
            txtPeso.Clear();
            txtAltura.Clear();
            lblResultado.Text = "";
        }
    }
}
