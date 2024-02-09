using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplex
{
    // Класс калькулятора
    public class ComplexCalculator
    {
        private readonly ICalculatorOperation _additionOperation;
        private readonly ICalculatorOperation _multiplicationOperation;
        private readonly ICalculatorOperation _divisionOperation;

        public ComplexCalculator(
            ICalculatorOperation additionOperation,
            ICalculatorOperation multiplicationOperation,
            ICalculatorOperation divisionOperation)
        {
            _additionOperation = additionOperation;
            _multiplicationOperation = multiplicationOperation;
            _divisionOperation = divisionOperation;
        }

        public ComplexNumber Add(ComplexNumber num1, ComplexNumber num2)
        {
            return _additionOperation.Calculate(num1, num2);
        }

        public ComplexNumber Multiply(ComplexNumber num1, ComplexNumber num2)
        {
            return _multiplicationOperation.Calculate(num1, num2);
        }

        public ComplexNumber Divide(ComplexNumber num1, ComplexNumber num2)
        {
            return _divisionOperation.Calculate(num1, num2);
        }
    }
}
