﻿namespace DesignPatterns.Atividades.Impostos
{
    public class Iss : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
