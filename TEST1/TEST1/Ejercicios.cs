using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TEST1
{
    class Ejercicios
    {
        //Ejercicio: Hacer una funcion que imprima por pantalla los numeros del 0 al 99

        public static void Ejercicio1()
        {
            int contador;
            
            contador = 0;

            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1;
                // contador += 1;
                contador++;

            }
        }

        //Ejercicio2: Haz una funcion que imprima los numero pares que hay desde el cero hasta n

        public static void Ejercicio2(int n)
        {
            int i;

            i = 0;

            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;

            }
        }
        //Ejercicio 3: si es primo o no
        public static void Ejercicio3(int n, int m)
        {
            while (n <= m)
            {
                bool aux = Utils.IsPrime(n);
                if (aux)
                {
                        System.Console.WriteLine("El " + n + " es primo");
                }
                    else
                {
                        System.Console.WriteLine("El " + n + " no es primo");
                }
                ++n;
            }
        }

        // Ejercicio 4: Devuelve el numero en asteriscos
        public static void Ejercicio4(int count)
        {
            int i = 0;

            while (i < count)
            {
                System.Console.WriteLine("*");
                i++;
            }

        }

        public static void Ejercicio5(int count1)
        {
            for(int i = 0 ; i <= 100 ; i++)
            {
                System.Console.WriteLine("*");
            }
        }

        
       

    }
}
