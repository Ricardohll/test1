using System.Reflection.Metadata.Ecma335;

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
    }
}
