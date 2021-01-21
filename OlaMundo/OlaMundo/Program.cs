using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o seu endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Digite o seu telefone: ");
            telefone = Console.ReadLine();

            //Console.WriteLine("Seu nome é: " + nome + " e você mora em " + endereco + " e seu telefone é: " + telefone);
            Console.WriteLine("Seu nome é {0}, você mora em {1} e seu telefone é {2}", nome, endereco, telefone);


        }
    }
}
