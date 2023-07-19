namespace DesignPatterns.Atividades.Impostos
{
    public class Iccc : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double taxa = 0;

            if (orcamento.Valor < 1000) taxa = orcamento.Valor * 0.05;

            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000) taxa = orcamento.Valor * 0.07;

            else if (orcamento.Valor > 3000) taxa = orcamento.Valor * 0.08 + 30;

            return taxa;
        }
    }
}
