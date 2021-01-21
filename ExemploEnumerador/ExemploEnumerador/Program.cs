using System;

namespace ExemploEnumerador
{
    class Program
    {
        enum TipoDiretor
        {
            Marketing,
            RH,
            Comercial,
            Financeiro
        }
        static void Main(string[] args)
        {
            TipoDiretor tpDiretor = TipoDiretor.Comercial;
            Console.WriteLine("O valor da variavel tpDiretor é {0}", tpDiretor);
        }
    }
}
