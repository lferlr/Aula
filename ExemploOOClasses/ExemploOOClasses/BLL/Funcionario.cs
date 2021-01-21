using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploOOClasses.BLL
{
    class Funcionario
    {
        private string _nome;
        private string _idade;
        private string _sexo;
        private double _salario;

        public string Nome { get => _nome; set => _nome = value; }
        public string Idade { get => _idade; set => _idade = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public double Salario { get => _salario; set => _salario = value; }

        public double calculaDecimoTerceiro(int mesesTrabalhados)
        {
            double decimoTerceiro;
            decimoTerceiro = _salario * mesesTrabalhados / 12;
            return decimoTerceiro;
        }

        public void calculaFerias()
        {
            double ferias;
            ferias = _salario + _salario / 3;
            Console.WriteLine("O salário de férias é R$ " + ferias + " Reais.");
        }
    }
}
