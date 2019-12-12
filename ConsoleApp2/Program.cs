using ConsoleApp2.ExpressionAlgebrique;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition add1 = new Addition();
            add1.Add(new Nombre(4));
            add1.Add(new Nombre(5));

            Multiplication mult1 = new Multiplication();
            mult1.Add(new Nombre(6));
            mult1.Add(new Nombre(3));
            add1.Add(mult1);

            add1.Add(new Nombre(12));
            Console.WriteLine("évaluation = "+add1.Evaluer());
            add1.Afficher();
            Console.ReadKey();
        }
    }
}
