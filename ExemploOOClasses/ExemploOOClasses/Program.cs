using ExemploOOClasses.BLL;
using System;

namespace ExemploOOClasses
{
    class Program
    {


        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do funcionário: ");
            funcionario.Idade = Console.ReadLine();
            Console.WriteLine("Digite o sexo do funcionário: ");
            funcionario.Sexo = Console.ReadLine();
            Console.WriteLine("Digite o salario do funcionário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("O funcionário {0} possui {1} anos, ele é do sexo {2} e seus salário é {3}", funcionario.Nome, funcionario.Idade, funcionario.Sexo, funcionario.Salario);
            Console.WriteLine("O funcionário {0} estará de férias no periodo de 16/09/2020 à 16/10/2020.", funcionario.Nome);
            funcionario.calculaFerias();
            Console.WriteLine("O funcionario {0} receberá R${1} reais referente ao seu décimo tercceiro.", funcionario.Nome, funcionario.calculaDecimoTerceiro(8));
        }
    }
}
