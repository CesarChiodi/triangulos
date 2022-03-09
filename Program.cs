using System;

namespace triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l1, l2, l3;
            Console.WriteLine("informe a medida do primeiro lado do triangulo");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a medida do segundo lado do triangulo");
            l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe a medida do terceiro lado do triangulo");
            l3 = int.Parse(Console.ReadLine());
            if ((l1 == l2 || l2 == l3 || l1 == l3))
                Console.WriteLine("isosceles");
            else 
            {
                if ((l1 == l2) && (l2 == l3))
                {
                    Console.WriteLine("equilátero");
                }
                else
                    Console.WriteLine("escaleno");
            }
        }
    }
}
