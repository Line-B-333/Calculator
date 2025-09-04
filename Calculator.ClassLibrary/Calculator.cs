using System.Text;

namespace Calculator.ClassLibrary
{
    /// <summary>
    /// This is a simple calculator class, with no internal state
    /// (No internal state means the class has no fields or instance variables to store data or values.).
    /// 
    /// Declared static because it holds only utility methods and
    /// should not be instantiated.
    /// 
    /// The methods are static to access them without creating an instance of the class.
    /// 
    /// @author Line Bertelsen 
    /// @date 04-09-2025
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Adds two float numbers together,
        /// and returns their sum.
        /// 
        /// A float is a 32-bit single-precision floating-point number, with about 7 digits of precision.
        /// </summary>
        public static float Add(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }


        /// <summary>
        /// Subtract two float numbers,
        /// and returns the difference. 
        /// </summary>        
        public static float Subtract(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Divides the first float by the second, 
        /// and returns the quotient. 
        /// </summary>
        public static float Divide(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// Multiply two float numbers together,
        /// and returns the product.
        /// </summary>
        public static float Multiply(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static void Calculation(params string[] numbers)
        {
            if (numbers.Length >= 3)
            {
                //float firstNumber = float.Parse(numbers[0]);                
                //float secondNumber = float.Parse(numbers[2]);

                
                //Checks if its a valid float number
                if (!float.TryParse(numbers[0], out float firstNumber) || !float.TryParse(numbers[2], out float secondNumber))
                {
                     Console.WriteLine(ErrorMessage());
                     return;
                }

                // Variables to hold the operation and result
                string operation = numbers[1];
                float result;

                //Switch between the operations and call the right method
                switch (operation)
                {
                    case "+":
                        result = Add(firstNumber, secondNumber);
                        break;

                    case "-":
                        result = Subtract(firstNumber, secondNumber);
                        break;

                    case "/":
                        result = Divide(firstNumber, secondNumber);
                        break;

                    case "*":
                        result = Multiply(firstNumber, secondNumber);
                        break;

                    default:
                        Console.WriteLine(ErrorMessage());
                        return;
                }

                //Print the calculation using the method PrintCalculation
                PrintCalculation(firstNumber, secondNumber, result, operation);
            }

            //If the input is invalid, print an error message, using the method ErrorMessage
            else
            {
                Console.WriteLine(ErrorMessage());
            }
            
        }

        /// <summary>
        /// Takes the two float numbers, the result and the operation as parameters,
        /// and prints the calculation in a readable format.
        /// </summary>
        public static void PrintCalculation(float firstNumber, float secondNumber, float result, string operation)
        {
            Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
        }


        /// <summary>
        /// If the user input is invalid, this method returns an error message
        /// </summary>
        public static string ErrorMessage()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine("Something went wrong");
            stringbuilder.AppendLine("----------------------------");
            stringbuilder.AppendLine("1. Wrong comma sign:");
            stringbuilder.AppendLine("    Please use ',' not '.'");
            stringbuilder.AppendLine("----------------------------");
            stringbuilder.AppendLine("2. Not spacing:");
            stringbuilder.AppendLine("    please use a space between each action.");
            stringbuilder.AppendLine("----------------------------");
            stringbuilder.AppendLine("3. Unsupported operation:");
            stringbuilder.AppendLine("    Please use '+', '-', '/' or '*'.");
            stringbuilder.AppendLine("----------------------------");
            stringbuilder.AppendLine("4. Equation example:");
            stringbuilder.AppendLine("    2,1 + 3,5.");
            return stringbuilder.ToString();
        }
    }
}