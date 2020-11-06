
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
        // Ejercicio 5: Hacer una funcion para que se le pasen tres string y devuelva la que concalizacion
        public static string Ejercicio5(string a, string b, string c)
        {
            return a + b + c;
        }

        // Ejercicio 6: Hacer una funcion que reciba dos enteros y devuelva menos uno si el primero es mayor que el segundo, 
        //mas uno si el segundo es menor que el primero, 0 en cualquier otro caso (iguales)
        public static int Ejercicio6(int a, int b)
        {
            if (a < b)
                return -1;
            else
                if (a > b)
                return +1;
            return 0;

        }
        // Ejercicio 7: hacer una funcion que te debuelva el menor de tres enteros
        public static int Ejercicio7(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            if (b <= c)
                return b;
            else
                return c;
            // if (a <= b)
            // {
            // if (a < c)
            //  return a;
            //  else
            //  return c;
            // }
            // else
            // {
            //  if (b < c)
            // {
            //  return b;
            // else
            //  retrun c;
            // }
        }
        // Ejercicio 8: Hacer una funcion que reciba un codigo de error y que imprima por pantalla 
        //"error grave" si el codigo de error es 0, 
        //"error moderado" si es 1,
        // "error leve" si es 2
        // "error desconocido" en cualquier otro caso
        public static void ejercicio8(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("error grave");
                    break;
                case 1:
                    System.Console.WriteLine("error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("error leve");
                    break;
                default:
                    System.Console.WriteLine("error desconocido");
                    break;
            }
        }

        //Ejercicio 9: Hacer una funcion a la que se pase un numero e imprima por pantalla una serie como la siguiente:
        //funcion(10) 0,3,6,9
        // " (15) 0,3,6,9,12,15
        // " (2) 0,
        public static void ejercicio9(int a)
        {
            int i = 0;
            while (a <= i)
            {
                System.Console.Write(i + ", ");
                i += 3;
            }
        }
        // Ejercicio 10: Hacer una funcion que imprima por pantalla la siguiente serie:
        //serie(10) 0,1,2,3,4,5,6,7,8,9
        public static void ejercicio10(int a)
        {
            for (int i = 0; i < a; i++)
            {
                System.Console.Write(i + ", ");
            }
        }
        // Ejercicio 11: Hacer una funcion como el anterior enemigo pero sin coma en el ultimo numero
        public static void ejercicio11(int a)
        {
            int i = 0;
            for (i = 0; i < a; i++)
                System.Console.Write(i + ", ");

            if (i < a - 1)
                System.Console.Write(i);
        }

        // Ejercicio 12: Hacer una funcion que se le pase un numero e imprima una serie de asteriscos
        public static void ejercicio12(int a)
        {
            for (int b = 0; b < a; b++)
                System.Console.Write("*");
        }
        // Ejercicio 13: Hacer una funcion que se le pase un numero e imprima "* + * + * ..."
        public static void ejercicio13(int a)
        {
            for (int i = 0; i < a; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("* ");
                else
                    System.Console.Write("+ ");
            }
        }

        // Ejercicio 14: Hacer una funcion que devuelva el menor de nueve enteros, la funcion tiene que ocupar una sola linea
        public static int ejercicio14(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            int menor1 = Ejercicio7(n1, n2, n3);
            int menor2 = Ejercicio7(n4, n5, n6);
            int menor3 = Ejercicio7(n7, n8, n9);
            return Ejercicio7(menor1, menor2, menor3);
        }
        // Ejercicio 15:
        public static void ejercicio15(int n1)
        {
            for(int f=0; f<n1; f++)
            {
                for(int c=0; c<n1; c++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine("");
            }
        }
        // Ejercicio 16:
        public static void ejercicio16(int n)
        {
            for(int f=0; f<n; f++)
            {
                for(int c=0; c<n; c++)
                {
                    
                    if ((f % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                    
                }
                System.Console.WriteLine("");
            }
        }
        // Ejercicio 17:
        public static void ejercicio17(int n)
        {
            for(int f=0; f<n; f++)
            {
                for(int c=0; c<=f; c++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine("");
            }
        }
        // Ejercicio 18:
        public static void ejercicio18(int n)
        {
            for(int f=0; f<n; f++)
            {
                int nespacios = n - f - 1;
                int nasteriscos = f + 1;
                for(int c=0; c<nespacios; c++)
                {
                    System.Console.Write(" ");
                }
                for(int c1=0; c1<nasteriscos; c1++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
        }
        // Ejercicio 19: 
        public static void ejercicio19(int n)
        {
            for(int f=0; f<n; f++)
            {
                int nesp1 = n - f - 1;
                int nesp2 = f * 2;
                for(int c=0; c<nesp1; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                for(int c1=0; c1<nesp2; c1++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine("*");
            }
        }
        // Ejercicio 20:
        public static void ejercicio20(int n)
        {
            for(int f=0; f<n; f++)
            {
                int nesp1 = f * 2;
                int nesp2 = ((n - f - 1) * 2);
                for(int c=0; c<nesp1; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                for(int c1=0; c1<nesp2; c1++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine("*");
            }
        }
        // Ejercicio 21:
        public static void ejercicio21(int n)
        {
            ejercicio19(n);
            ejercicio20(n);
        }
        // Ejercicio 22: Hacer una funcion que devuelva  dos elevado a n, siendo n el parametro que reciba la funcion
        public static int ejercicio22(int n)
        {
            int solucion = 0;

            for(int i=0; i <= n; i++)
            {
              solucion *=2;
            }

            return solucion;
        }

    }
}
