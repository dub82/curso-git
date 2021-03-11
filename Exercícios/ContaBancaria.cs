using System;
using System.Globalization;

namespace Exercícios
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        private double Taxa = 5.0;
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        


        public ContaBancaria() { }

        public ContaBancaria(int numero, string nome)
        {
            NumeroConta = numero;
            NomeTitular = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Deposito(saldo);
        }

        
        public void Deposito(double valor)
        {
           Saldo = Saldo + valor;
        }

        public void Saque (double valor)
        {
            Saldo = Saldo - valor - Taxa;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Nome do titular: "
                + NomeTitular
                + ", Saldo atual: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
              
         
        }



    }
}
