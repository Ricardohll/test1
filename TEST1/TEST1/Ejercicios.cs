using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
