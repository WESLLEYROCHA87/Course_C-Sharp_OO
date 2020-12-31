using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerc_ContaBancaria.Entities
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(int conta, string nome, double deposito) : this(conta, nome)
        {
            Saldo = deposito;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }


        public override string ToString()
        {
            return "Conta: " + Conta + ", Nome: " + Nome + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
