namespace DesignPatterns.Atividades
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
