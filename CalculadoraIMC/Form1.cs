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
                // Lê os valores de peso e altura
                float peso = float.Parse(txtPeso.Text);
                float altura = float.Parse(txtAltura.Text);

                // Valida se os valores são positivos
                if (peso > 0 && altura > 0)
                {
                    // Calcula o IMC
                    float imc = peso / (altura * altura);

                    // Formata o resultado para 2 casas decimais
                    string resultadoIMC = imc.ToString("F2");

                    // Interpreta o valor do IMC
                    string interpretacao = InterpretarIMC(imc);

                    // Exibe o resultado no Label
                    lblResultado.Text = $"Seu IMC é {resultadoIMC}. {interpretacao}";
                }
                else
                {
                    MessageBox.Show("Peso e altura devem ser valores positivos.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para peso e altura.");
            }
        }

        // Função para interpretar o valor do IMC
        private string InterpretarIMC(float imc)
        {
            if (imc < 18.5)
                return "Você está abaixo do peso.";
            else if (imc >= 18.5 && imc < 24.9)
                return "Você está com peso normal.";
            else if (imc >= 25 && imc < 29.9)
                return "Você está com sobrepeso.";
            else
                return "Você está com obesidade.";
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
