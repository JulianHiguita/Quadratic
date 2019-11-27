using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface IQuadraticService
    {
        double GetQuadraticX1(double a, double b, double c);
        double GetQuadraticX2(double a, double b, double c);

    }
}
