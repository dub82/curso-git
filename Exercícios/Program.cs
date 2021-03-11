using System;
using System.Globalization;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();
            Console.WriteLine("Entre com os dados da conta bancária: ");
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char dep = char.Parse(Console.ReadLine());
            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, nome, saldo);
            }
            else
            {
                c = new ContaBancaria(numero, nome);
            }
            Console.WriteLine();

            Console.Write("Dados da conta: ");
            Console.Write(c);

            Console.WriteLine();

            Console.Write("Deseja efetuar um depósito? ");
            dep = char.Parse(Console.ReadLine());
            if(dep == 's' || dep == 'S') 
            {
                Console.Write("Entre com um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Deposito(deposito);
                Console.WriteLine(c);
            }
            Console.Write("Deseja efetuar um Saque? ");
            dep = char.Parse(Console.ReadLine());
            if (dep == 's' || dep == 'S') 
            {
                Console.Write("Entre com um valor para o saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Saque(saque);
                Console.WriteLine(c);
            }


        }
    }
}
