using System;
using System.Collections;

namespace ExemploArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            Lista.Add("Tópicos Avançados em Programação");
            Lista.Add("19/09/2020");
            Lista.Add(2020);
            Lista.Add("xxxxxxxxxxxxxxx");
            Lista.Add(null);
            Lista.Add(true);
            Lista.Add("#################");
            Lista.Add(12.45);
            Lista.Add(18.15f);
            Console.WriteLine("ArrayList lista");
            Console.WriteLine("Capacidade do ArrayList-lista {0}", Lista.Capacity);
            Console.WriteLine("O tamanho do ArrayList-lista {0}", Lista.Count);
            Console.WriteLine("Removendo o elemento - XXXXXXXXXXXXXX");
            Lista.Remove("xxxxxxxxxxxxxxx");
            Console.WriteLine("Inserindo o novo elemento:");
            Lista.Add("Fim");
            Console.WriteLine("Varrendo o ArrayList Lista");

            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine("O indice {0} possui o seguinte conteúdo {1}", i, Lista[i]);
            }
        }
    }
}
