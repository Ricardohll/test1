using System;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vector, vector3d, min;

            vector = geometry.GetVector(1.0, 1.0);

            System.Console.WriteLine("la solucion del vector 2D es: " + vector);

            vector3d = geometry.GetVector3D(1.0, 1.0, 1.0);

            System.Console.WriteLine("la solucion del vector 3D es: " + vector3d);

            min = Utils.GetMinValue(1, 5);

            System.Console.WriteLine("El valor mas pequeño es: " + min);


        }
    }
}
