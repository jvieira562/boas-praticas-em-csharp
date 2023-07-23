using TemplateMethod.Impostos.Abstracoes;

namespace TemplateMethod
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double i = imposto.Calcula(orcamento);
            Console.WriteLine(i);
        }
    }
}
