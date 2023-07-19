namespace Strategy.Estrategias
{
    public class Moderado : Investimento
    {
        public double RetornaValorInvestido(double valor)
        {
            bool escolhido = new Random().Next(101) > 50;

            if (escolhido) return valor * 0.025;
            else return valor * 0.007;
        }
    }
}
