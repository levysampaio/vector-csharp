using System;

namespace CursoCShrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();

            Console.WriteLine("Entre com o número da conta: ");
            c1.NumConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            c1.Cliente = Console.ReadLine();

            Console.WriteLine("Deseja entrar com um valor inicial? s/n");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao.Equals('s'))
            {
                Console.WriteLine("Entre com o valor inicial:");
                c1.Deposito(double.Parse(Console.ReadLine()));

                Console.WriteLine("----------------");
                Console.WriteLine("Dados da Conta:");
                Console.WriteLine(c1);
                Console.WriteLine("----------------");
            }
            else
            {
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
