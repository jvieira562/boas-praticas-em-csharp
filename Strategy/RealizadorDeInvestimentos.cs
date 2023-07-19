namespace Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(Conta conta, Investimento investimento)
        {
            Console.WriteLine($"Seu dinheiro será investido");

            double rendimentoBruto = investimento.RetornaValorInvestido(conta.Saldo);
            double rendimentoLiquido = rendimentoBruto - (rendimentoBruto * 0.25);

            conta.Depositar(rendimentoLiquido);

        }
    }
}
