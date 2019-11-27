using System;
using System.Collections.Generic;
using System.Text;


namespace QuadraticEquations.Core.Services
{
    public class QuadraticService : IQuadraticService
    {
        double x1;
        double x2;
        public double GetQuadraticX1(double a, double b, double c)
        {


            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);


            return x1;

        }

        public double GetQuadraticX2(double a, double b, double c)
        {



            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            return x2;

        }
    }
}
