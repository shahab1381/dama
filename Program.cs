using System;

class Program
{
    static void Main()
    {
        // Getting temperature input from the user
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Calculating Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Displaying the result
        Console.WriteLine("Equivalent Fahrenheit temperature: " + fahrenheit);

        // Displaying the equation
        Console.WriteLine("Conversion equation: F = (9/5) * C + 32");
    }
}
