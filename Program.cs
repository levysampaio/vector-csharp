using System;

namespace CursoCShrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;

            Console.WriteLine("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            string cliente = Console.ReadLine();

            Console.WriteLine("Deseja entrar com um valor inicial? s/n");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao.Equals('s'))
            {
                Console.WriteLine("Entre com o valor inicial:");
                double valorInicial = double.Parse(Console.ReadLine());

                c1 = new Conta(cliente, numConta, valorInicial);
                Console.WriteLine("----------------");
                Console.WriteLine("Dados da Conta:");
                Console.WriteLine(c1);
                Console.WriteLine("----------------");
            }
            else
            {
                c1 = new Conta(cliente, numConta);
                Console.WriteLine("----------------");
                Console.WriteLine("Dados da Conta:");
                Console.WriteLine(c1);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("Entre com um deposito:");
            c1.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("----------------");
            Console.WriteLine("Dados da Conta atualizado:");
            Console.WriteLine(c1);
            Console.WriteLine("----------------");

            Console.WriteLine("Entre com um saque:");
            c1.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("----------------");
            Console.WriteLine("Dados da Conta atualizado:");
            Console.WriteLine(c1);
            Console.WriteLine("----------------");
        }


    }
}
