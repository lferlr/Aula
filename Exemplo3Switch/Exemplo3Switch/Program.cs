using System;

namespace Exemplo3Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine("O número que você selecionou é o 1");
                    break;
                case 2:
                    Console.WriteLine("O número que você selecionou é o 2");
                    break;
                default:
                    Console.WriteLine("Você digitou um numero diferente de 1 ou 2");
                    break;
            }
            Console.ReadKey();
        }
    }
}
