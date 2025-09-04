namespace Calculator.CommandLineApp;
using CalcLib = Calculator.ClassLibrary;

// Internal: An access modifier
// Only visble inside the assembly (project/compilled DLL)
// Even if Calculator.CommandLineApp had a project refference to Calculator.ClassLibrary 
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CalcLib.Calculator calculator = new CalcLib.Calculator();
    }
}
