using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplex.Operation
{
    // Операция умножения
    public class MultiplicationOperation : ICalculatorOperation
    {
        public ComplexNumber Calculate(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber result = new ComplexNumber();
            result.Real = num1.Real * num2.Real - num1.Imaginary * num2.Imaginary;
            result.Imaginary = num1.Real * num2.Imaginary + num1.Imaginary * num2.Real;
            return result;
        }
    }
}
