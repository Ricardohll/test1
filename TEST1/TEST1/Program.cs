using System;
using System.Security.Cryptography.X509Certificates;

namespace TEST1
{
    class Program
    {
        public static void Rombo(int n)
        {
            while(true)
            {
                for(int i=0; i<10; i++)
                {
                    EjercicioExamen.ejercicio21(i);
                    System.Threading.Thread.Sleep(300);
                    System.Console.Clear();
                }
            }
        }
        static void Main(string[] args)
        {
            EjercicioExamen.ejercicio26(8);
            
        }
    }
}
