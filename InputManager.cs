using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComplex
{
    public class InputManager
    {
        public static ComplexNumber ReadComplexNumber()
        {
            Console.Write("Введите вещественную часть: ");
            double real = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите мнимую часть: ");
            double imaginary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            return new ComplexNumber { Real = real, Imaginary = imaginary };
        }
    }
}
