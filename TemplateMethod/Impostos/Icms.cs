using TemplateMethod.Impostos.Abstracoes;

namespace TemplateMethod.Impostos
{
    public class Icms : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.00;
        }
    }
}
