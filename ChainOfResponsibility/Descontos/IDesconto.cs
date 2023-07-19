namespace ChainOfResponsibility.Descontos
{
    public interface IDesconto
    {
        public double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
