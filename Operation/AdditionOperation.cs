using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorComplex.Operation
{
    // Операция сложения
    public class AdditionOperation : ICalculatorOperation
    {
        public ComplexNumber Calculate(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber result = new ComplexNumber();
            result.Real = num1.Real + num2.Real;
            result.Imaginary = num1.Imaginary + num2.Imaginary;
            return result;
        }
    }
}
