using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCShrap
{
    class Conta
    {
        public string Cliente { get; private set; }
        public int NumConta { get; set; }
        public double Saldo { get; private set; }

        public Conta(string cliente, int conta)
        {
            Cliente = cliente;
            NumConta = conta;
        }

        public Conta(string cliente, int conta, double quantia) : this(cliente, conta)
        {
            Deposito(quantia);

        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Cliente: " + Cliente + " | Conta: " + NumConta + " | Saldo: " + Saldo;
        }

    }
}
