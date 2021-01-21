using System;

namespace ExemploNumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 != 0)
            {
                Console.WriteLine("Número é impar!");
            } else
            {
                Console.WriteLine("Número par!");
            }
            Console.ReadKey();

            //int numeroDigitado
            //string resultado;
            //Console.WriteLine("Digite um numero: ")
            //numeroDigitado = Convert.ToInt32(Console.ReadLine());
            //resultado = numeroDigitado % 2 == 0 ? "O numero digitado é par" : "O numero digitado é impar";
            //Console.WriteLine(resultado);

        }
    }
}
