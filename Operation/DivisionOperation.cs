using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplex.Operation
{
    // Операция деления
    public class DivisionOperation : ICalculatorOperation
    {
        public ComplexNumber Calculate(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber result = new ComplexNumber();
            double denominator = num2.Real * num2.Real + num2.Imaginary * num2.Imaginary;
            result.Real = (num1.Real * num2.Real + num1.Imaginary * num2.Imaginary) / denominator;
            result.Imaginary = (num1.Imaginary * num2.Real - num1.Real * num2.Imaginary) / denominator;
            return result;
        }
    }
}
