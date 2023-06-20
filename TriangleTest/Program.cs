using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the sides of a triangle:");

        // Read input from the user
        int side1 = ReadInteger("Side 1: ");
        int side2 = ReadInteger("Side 2: ");
        int side3 = ReadInteger("Side 3: ");

        // Determine the type of triangle
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is scalene.");
        }
    }

    // Helper method to read an integer from the user
    static int ReadInteger(string prompt)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        } while (!isValid);

        return value;
    }
}