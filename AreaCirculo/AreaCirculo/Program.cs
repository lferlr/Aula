using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area do circulo area = PI*R2

            double areaCirculo = 0;
            double raioCirculo;
            Console.Write("Informe o raio do circulo: ");
            raioCirculo = Convert.ToDouble(Console.ReadLine());

            areaCirculo = Math.PI * Math.Pow(raioCirculo,2);
            Console.WriteLine("A área do circulo de raio {0} é igual {1}", raioCirculo, areaCirculo);


        }
    }
}
