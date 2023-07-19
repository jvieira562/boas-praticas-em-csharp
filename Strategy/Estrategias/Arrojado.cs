namespace Strategy.Estrategias
{
    public class Arrojado : Investimento
    {
        public double RetornaValorInvestido(double valor)
        {
            int chance = new Random().Next(101);
            double rendimento = 0;

            if (chance <= 20) rendimento = valor * 0.05;
            else if (chance > 20 && chance <= 30) rendimento = valor * 0.03;
            else if (chance > 30 && chance >= 50) rendimento = valor * 0.006;

            return rendimento;
        }
    }
}
