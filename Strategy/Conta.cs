namespace Strategy
{
    public class Conta
    {

        public string Id { get; private set; }
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 18);
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            if (valor > 0) {
                Saldo = Saldo + valor;
                Console.WriteLine(
                @$"Deposito efetuado: { Id }

Saldo inicial: { Saldo - valor }.
Saldo final: { Saldo }.");
            }
        }
    }
}