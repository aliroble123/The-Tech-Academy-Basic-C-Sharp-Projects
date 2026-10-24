using System; // Provides access to Console input and output.

namespace CSharpMethodAssignment // Groups the classes in this application.
{
    public class Calculator // Defines a class that performs a calculation.
    {
        // Defines a void method that accepts two integer parameters.
        public void PerformCalculation(int firstNumber, int secondNumber)
        {
            // Multiplies the first number by 2 and stores the answer.
            int result = firstNumber * 2;

            // Displays the result of the calculation.
            Console.WriteLine("First number multiplied by 2: " + result);

            // Displays the second number passed to the method.
            Console.WriteLine("Second number: " + secondNumber);
        }
    }

    internal class Program // Contains the entry point for the application.
    {
        // Main is the method that runs first when the application starts.
        static void Main(string[] args)
        {
            // Creates an object (instance) of the Calculator class.
            Calculator calculator = new Calculator();

            // Calls the method using positional arguments.
            calculator.PerformCalculation(5, 10);

            // Calls the same method using named arguments.
            calculator.PerformCalculation(firstNumber: 7, secondNumber: 20);

            // Waits for a key press so the console window can stay open.
            Console.ReadKey();
        }
    }
}
