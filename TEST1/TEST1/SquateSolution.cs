namespace TEST1
{
    class SquateSolution
    {
        public static double SolvedEcuation(double a, double b, double c)
        {
            double aux, aux2, x;

            aux = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux);
            x = (-b + aux2) / (2.0 * a);

            return x;

        }

        public static double SolvedEcuation2(double a2, double b2)
        {
            double x2;

            x2 = -b2 / a2;
            return x2;
        }
    }
}
