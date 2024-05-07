using System;


namespace Coding.Exercise

{
    
    public class Run
    {
        public delegate float OperationDelegate(float number1, float number2);
        static void Main(string[] args)
        {
            float num1;
            float num2;
            Console.WriteLine("Enter first number");
            float.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Enter second operator");
            float.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("Enter second number");
            float.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine($"{num1} + {num2} = {ApplyOperation(num1, num2, Add)}");
            Console.WriteLine($"{num1} - {num2} = {ApplyOperation(num1, num2, Subtract)}");
            Console.WriteLine($"{num1} * {num2} = {ApplyOperation(num1, num2, Multiply)}");
            Console.WriteLine($"{num1} / {num2} = {ApplyOperation(num1, num2, Divide)}");
        }
        public static float ApplyOperation(float number1, float number2, OperationDelegate operation)
        {
            return operation(number1, number2);
        }


        public static float Add(float number1, float number2)
        {
            return number1 + number2;
        }
        public static float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }
        public static float Multiply
        (float number1, float number2)
        {
            return number1 * number2;
        }
        public static float Divide(float number1, float number2)
        {
            if (number2 != 0)
                return number1 / number2;
            else
                Console.WriteLine("Error: Division by zero");
                return float.NaN;
        }

        
    }
}