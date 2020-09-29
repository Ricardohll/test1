namespace TEST1
{
    class geometry
    {
        public static GetVector(double x, double y)
        {
            double aux, length;

            aux = x * x + y * y;
            length = System.Math.Sqrt(aux);

            return length;
        }
    }
}
