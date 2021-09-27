using System;

namespace CursoCShrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();

            Console.WriteLine("Digite a largura do triangulo: ");
            t1.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo: ");
            t1.Altura = double.Parse(Console.ReadLine());

            Console.Write(t1);          
     
        }

   
    }
}
