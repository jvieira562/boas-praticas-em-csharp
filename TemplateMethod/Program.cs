using TemplateMethod.Impostos;
using TemplateMethod.Impostos.Abstracoes;

namespace TemplateMethod
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new Icms();
            Imposto iss = new Iss();
            Imposto iccc = new Iccc();
            Imposto icpp = new Icpp();
            Imposto ikvc = new Ikcv();
            Imposto ihit = new Ihit();

            var orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 50));

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, ihit);

            Console.ReadKey();
        }
    }
}
