namespace Prova_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_valorVenda.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string unidade = combo_unidade.Text;
                double valor = Convert.ToDouble(txt_valor.Text);//VALOR DO PRODUTO
                double pis = Convert.ToDouble(txt_pis.Text);//PORCENTAGEM IMPOSTO PIS
                double icms = Convert.ToDouble(txt_icms.Text);//PORCENTAGEM IMPOSTO ICMS
                double confins = Convert.ToDouble(txt_confins.Text);//PORCENTAGEM IMPOSTO CONFINS
                double lucro = Convert.ToDouble(txt_lucro.Text);//VALOR DE LUCRO



                if (unidade == "UN")
                {
                    //IMPOSTO
                    double somaImposto = pis + confins + icms;//15
                    double valorImposto = valor + (valor * somaImposto) / 100;//23
                    double valorLucro = (valorImposto * lucro) / 100;
                    double valorVenda = valorImposto + valorLucro;
                    lbl_valorVenda.Text = valorVenda.ToString("C2");
                }
                if (unidade == "LT" || unidade == "KL")
                {
                    //IMPOSTO

                    double somaImposto = pis + confins + icms;//15
                    double valorImposto = valor + (valor * somaImposto) / 100;//23
                    double valorLucro = (valorImposto * lucro) / 100;
                    double valorVenda = valorImposto + valorLucro;
                    double impostoUnidade = (valorVenda * 5) / 100;
                    double valorTotal = valorVenda + impostoUnidade;

                    lbl_valorVenda.Text = valorTotal.ToString("C2");
                }
                else if (unidade == "")
                {
                    MessageBox.Show("Unidade não preenchida");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



        }
    }
}