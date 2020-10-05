using System;
using System.Collections.Generic;
using System.Text;

namespace TEST1
{
    class Ejercicios
    {
        //Ejercicio: Hacer una funcion que imprima por pantalla los numeros del 0 al 99

        public static void Ejercicio()
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
    }
}
