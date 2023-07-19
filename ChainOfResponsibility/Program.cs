namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDeDescontos();
            
            var orcamento = new Orcamento(500);

            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogao", 250));
            orcamento.AdicionaItem(new Item("Ferro de passar", 250));
            orcamento.AdicionaItem(new Item("Xbox", 250));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine("Desconto: " + desconto);

        }
    }
}
