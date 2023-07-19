namespace Strategy.Estrategias
{
    public class Conservador : Investimento
    {
        public double RetornaValorInvestido(double valor)
        {
            return valor * 0.008;
        }
    }
}
