namespace Atividade23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                lblResultado.Text = $"IMC CALCULADO: {imc:F2} - Abaixo do peso";
            }
            else if (imc < 25)
            {
                lblResultado.Text = $"IMC CALCULADO: {imc:F2} - Peso normal";
            }
            else if (imc < 30)
            {
                lblResultado.Text = $"IMC CALCULADO: {imc:F2} - Sobrepeso";
            }
            else if (imc < 35)
            {
                lblResultado.Text = $"IMC CALCULADO: {imc:F2} - Obesidade grau I";
            }
            else if (imc < 40)
            {
                lblResultado.Text = $"IMC CALCULADO: {imc:F2} - Obesidade grau II";
            }
            else
            {
                lblResultado.Text = $"IMC CALCULADO: {imc:F2} - Obesidade grau III";
            }
        }
    }
}
