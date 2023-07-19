
using Strategy;
using Strategy.Estrategias;

var jose = new Conta(200);
jose.Depositar(150);

var investimento = new RealizadorDeInvestimentos();
investimento.Investir(jose, new Arrojado());

Console.ReadKey();