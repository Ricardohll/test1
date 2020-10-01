namespace TEST1
{
    class geometry
    {
        public static double GetVector(double x, double y)
        {
            double aux, length;

            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);

            return length;
        }

        public static double GetVector3D(double x3, double y3, double z3)
        {
            double aux2, length2;

            aux2 = x3 * x3 + y3 * y3 + z3 * z3;
            length2 = System.Math.Sqrt(aux2);

            return length2;
        }
    }
}
