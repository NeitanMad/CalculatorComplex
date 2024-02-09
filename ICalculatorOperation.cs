using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplex
{
    public interface ICalculatorOperation
    {
        ComplexNumber Calculate(ComplexNumber num1, ComplexNumber num2);
    }
}
