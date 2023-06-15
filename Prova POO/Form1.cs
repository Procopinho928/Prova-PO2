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

                Produto conexao = new Produto(unidade, valor, pis, icms, confins, lucro);


                lbl_valorVenda.Text = conexao.CalcularValorFinal();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



        }
    }
}