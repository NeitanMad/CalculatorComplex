using CalculatorComplex.Operation;
using Serilog;

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
            Console.WriteLine();

            bool shouldExit = false;

            // Создание экземпляра калькулятора с требуемыми операциями
            ComplexCalculator calculator = new ComplexCalculator(
            new AdditionOperation(),
            new MultiplicationOperation(),
            new DivisionOperation()
            );

            while (!shouldExit)
            {
                // Создание комплексных чисел
                Console.WriteLine("Введите первое комплексное число: ");
                ComplexNumber num1 = InputManager.ReadComplexNumber();

                Console.WriteLine("Введите второе комплексное число: ");
                ComplexNumber num2 = InputManager.ReadComplexNumber();

                // Сложение
                Log.Information("Addition");
                ComplexNumber sum = calculator.Add(num1, num2);
                Console.WriteLine($"Sum: {sum.Real} + {sum.Imaginary}i");
                Console.WriteLine();

                // Умножение
                Log.Information("Multiplication");
                ComplexNumber product = calculator.Multiply(num1, num2);
                Console.WriteLine($"Product: {product.Real} + {product.Imaginary}i");
                Console.WriteLine();

                // Деление
                Log.Information("Division");
                ComplexNumber quotient = calculator.Divide(num1, num2);
                Console.WriteLine($"Quotient: {quotient.Real} + {quotient.Imaginary}i");
                Console.WriteLine();

                Console.WriteLine("Введите exit, чтобы выйти, или нажмите Enter, чтобы продолжить.");

                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    shouldExit = true;
                    Console.WriteLine();
                }
            }

            Log.Information("Application finished");
            Log.CloseAndFlush();
        }
    }
}