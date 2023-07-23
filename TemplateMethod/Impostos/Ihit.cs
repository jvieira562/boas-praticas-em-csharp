using TemplateMethod.Impostos.Abstracoes;

namespace TemplateMethod.Impostos
{
    public class Ihit : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ContemDoisItemsComMesmoNome(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01;
        }

        private bool ContemDoisItemsComMesmoNome(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(item => item.Nome).Any(grupo => grupo.Count() > 1);
        }
    }
}
