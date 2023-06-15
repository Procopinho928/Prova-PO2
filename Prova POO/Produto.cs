public class Produto
{
    public string unidade;
    public double valor;
    public double pis;
    public double icms;
    public double confins;
    public double lucro;

    public Produto(string unidade, double valor, double pis, double icms, double confins, double lucro)
    {
        this.unidade = unidade;
        this.valor = valor;
        this.pis = pis;
        this.icms = icms;
        this.confins = confins;
        this.lucro = lucro;
    }

    public string CalcularValorFinal()
    {

        if (unidade == "UN")
        {
            //IMPOSTO
            double somaImposto = pis + confins + icms;//15
            double valorImposto = valor + (valor * somaImposto) / 100;//23
            double valorLucro = (valorImposto * lucro) / 100;
            double valorVenda = valorImposto + valorLucro;
            return valorVenda.ToString("C2");
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

            return valorTotal.ToString("C2");
        }
        
        return "Unidade não preenchida";
        
    }
}