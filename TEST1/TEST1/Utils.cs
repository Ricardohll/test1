using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace TEST1
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int GetMaxValue(int a2, int b2)
        {
            if (a2 > b2)
                return a2;
            else
                return b2;
        }
        // IsEven devuelve true si el valor es par y false en caso contrario.
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }

        public static bool IsPrime(int number)
        {
            int i = 2;

            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                ++i;
            }

            return true;
        }
    }
}
