using System;

namespace QuadraticEquationProject
{
    public class QuadraticEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double D;

        private double[] X = new double[2];
        public string EquationCalculation(double A, double B, double C)
        {
            if (A == 0)
            {
                return ("First term coefficient must be not 0");
            }
            else
            {
                D = B * B - 4 * A * C;
                if (D < 0)
                {
                    return "This equation has no valid roots";
                }
                if (D == 0)
                {
                    X[0] = ((-1) * B) / (2 * A);
                    if (X[0] == 0)
                        X[0] = 0;

                    return String.Format("This equation has one valid root: {0}", X[0]);
                }
                else
                {
                    X[0] = ((-1) * B - Math.Sqrt(D)) / (2 * A);
                    X[1] = ((-1) * B + Math.Sqrt(D)) / (2 * A);

                    return String.Format("This equation has two valid roots: {0}, {1}", X[0], X[1]);
                }
            }
        }
    }
}
