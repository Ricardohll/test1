using System;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, vector;

            s1 = SquateSolution.SolvedEcuation(0.1, 2.0, 3.0);

            System.Console.WriteLine("la solucion de s1 es: " + s1);

            s2 = SquateSolution.SolvedEcuation2(5.0, 2.0);

            System.Console.WriteLine("la solucion de s2 es: " + s2);

            vector = geometry.GetVector(1.0, 1.0);

            System.Console.WriteLine("la solucion del vector es: " + vector);

        }
    }
}
