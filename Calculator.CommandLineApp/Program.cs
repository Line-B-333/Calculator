namespace Calculator.CommandLineApp;
using CalcLib = Calculator.ClassLibrary;

// Internal: An access modifier
// Only visble inside the assembly (project/compilled DLL)
// Even if Calculator.CommandLineApp had a project refference to Calculator.ClassLibrary 
internal class Program
{
    static void Main(string[] args)
    {
        CalcLib.Calculator.Calculation(args);

        /*
        if (args.Length >= 3)
        {
            float firstNumber = float.Parse(args[0]);
            string operation = args[1];
            float secondNumber = float.Parse(args[2]);
            

            if (operation == "+")
            {
                float result = CalcLib.Calculator.Add(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
            }
            else if (operation == "-")
            {
                float result = CalcLib.Calculator.Subtract(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
            }
            else if (operation == "/")
            {
                float result = CalcLib.Calculator.Divide(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
            }
            else if (operation == "*")
            {
                float result = CalcLib.Calculator.Multiply(firstNumber, secondNumber);
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
            }
                       
        }
        else
        {
            Console.WriteLine("\"Unsupported operation. Please use '+', '-', '/' or '*' \ne.g 2.1 + 3.5.");
        }*/
   
    }
}
