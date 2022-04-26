using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException: OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string mensagem): base(mensagem) { }
        public SaldoInsuficienteException(double saldo, double valorSaque): this("Tentatica de saque do valor de " + valorSaque + " em uma comta com saldo de " + saldo) { 
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna): base(mensagem, excecaoInterna) { }

    }
}
