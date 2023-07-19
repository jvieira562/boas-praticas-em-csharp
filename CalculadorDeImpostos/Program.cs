using DesignPatterns.Atividades.Impostos;
using DesignPatterns.Atividades;

namespace DesignPatterns
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new Icms();
            Imposto iss = new Iss();
            Imposto iccc = new Iccc();

            Orcamento orcamento = new Orcamento(3400);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
