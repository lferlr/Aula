using System;

namespace ComparacaoDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite um numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Os números são iguais!");
            }
            else 
            {
                Console.WriteLine("Os números são diferente!");
            }
            Console.ReadKey();
        }
    }
}
