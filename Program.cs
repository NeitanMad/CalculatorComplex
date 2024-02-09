using CalculatorComplex.Operation;
using Serilog;
using Serilog.Sinks.File;

namespace CalculatorComplex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Application started");

            // Создание экземпляра калькулятора с требуемыми операциями
            ComplexCalculator calculator = new ComplexCalculator(
                new AdditionOperation(),
                new MultiplicationOperation(),
                new DivisionOperation()
                );

            // Создание комплексных чисел
            ComplexNumber num1 = new ComplexNumber { Real = 2, Imaginary = 3 };
            ComplexNumber num2 = new ComplexNumber { Real = 4, Imaginary = 5 };

            // Сложение
            Log.Information("Addition");
            ComplexNumber sum = calculator.Add(num1, num2);
            Console.WriteLine($"Sum: {sum.Real} + {sum.Imaginary}i");

            // Умножение
            Log.Information("Multiplication");
            ComplexNumber product = calculator.Multiply(num1, num2);
            Console.WriteLine($"Product: {product.Real} + {product.Imaginary}i");

            // Деление
            Log.Information("Division");
            ComplexNumber quotient = calculator.Divide(num1, num2);
            Console.WriteLine($"Quotient: {quotient.Real} + {quotient.Imaginary}i");

            Log.Information("Application finished");
            Log.CloseAndFlush();

            Console.ReadKey();
        }
    }
}