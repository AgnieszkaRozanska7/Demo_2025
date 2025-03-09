using CalculatorApp.Services.Interfaces;

namespace CalculatorApp.Services
{
    internal class Calculate : ICalculate
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;   
        }

        public double Minus(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
