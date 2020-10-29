
using System;
using System.Runtime.InteropServices;

namespace TEST1
{
    class EjercicioExamen
    {
        //Ejercicio 1: Hacer una funcion a la que se le pase dos numeros enteros y devuelva el resultado de la suma de esos dos numeros.

        public static int Ejercicio1(int a, int b)
        {
            int valor = a + b;
            return valor;
            // return a+b; (simplifica esta funcion)
        }

        //Ejercicio 2: Hacer una funcion que reciba dos reales y devuelva la resta de esos dos reales.
        public static double Ejercicio2(double a, double b)
        {
            double valor = a - b;
            return valor;
        }
        //Ejercicio 3: Hacer una funcion a la que se le pase dos enteros y devuelva el menor de ellos.
        public static int Ejercicio3(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
            // 1 opcion
            // if (a < b)
            // return a;
            // return b;
            
            // 2 opcion
            //bool result
            // if (a < b)
            // result = a;
            // else
            // result = b;
            // return result;
        }
        // Ejercicio 4: Hacer una funcion que reciba como parametro dos enteros y devuelva si el primero es menor que el segundo
        public static bool Ejercicio4(int a, int b)
        {
            if (a < b)
            {
                return true;
            }
                else
            {
                return false;
            }

            // if (a < b)
            // return true;
            // else
            // return false;

            // if (a < b)
            // return true;
            // return false;
            
        }
    }
}
