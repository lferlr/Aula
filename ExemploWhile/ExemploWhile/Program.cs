using System;

namespace ExemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //estrutura de Repetição com teste no inicio
            //int n = 1;
            //while (n < 6)
            //{
            //    Console.WriteLine("O valor de n é : {0}", n);
            //    n++;
            //}
            //Console.ReadKey();

            
            //estrutura de Repetição com teste no final
            //int n = 1;
            //do
            //{
            //    Console.WriteLine("O valor de n é : {0}", n);
            //    n++;
            //} while (n < 5); 
            //Console.ReadKey();

            //
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("O valor de i é : {0}", i);
            }
            Console.ReadKey();
        }
    }
}
