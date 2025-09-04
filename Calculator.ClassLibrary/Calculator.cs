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
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Adds two float numbers together,
        /// and returns their sum.
        /// 
        /// A float is a 32-bit single-precision floating-point number, with about 7 digits of precision.
        /// 
        /// </summary>
        /// <param name="firstNumber">The first number to add.</param>
        /// <param name="secondNumber">The second number to add.</param>
        /// 
        /// <returns>The sum of <paramref name="firstNumber"/> and <paramref name="secondNumber"/>.</returns>
        public static float Add(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Subtract two float numbers,
        /// and returns the difference.
        /// 
        /// </summary>
        /// <param name="firstNumber">The first number to add.</param>
        /// <param name="secondNumber">The second number to add.</param>
        /// 
        /// <returns>The difference between <paramref name="firstNumber"/> and <paramref name="secondNumber"/>.</returns>
        public static float Subtract(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Divides the first float by the second, 
        /// and returns the quotient.
        /// 
        /// </summary>
        /// <param name="firstNumber">The first number to add.</param>
        /// <param name="secondNumber">The second number to add.</param>
        /// 
        /// <returns>The quotient of <paramref name="firstNumber"/> and <paramref name="secondNumber"/>.</returns>
        public static float Divide(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// Multiply two float numbers together,
        /// and returns the product.
        /// 
        /// </summary>
        /// <param name="firstNumber">The first number to add.</param>
        /// <param name="secondNumber">The second number to add.</param>
        /// 
        /// <returns>The product of <paramref name="firstNumber"/> and <paramref name="secondNumber"/>.</returns>
        public static float Multiply(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
