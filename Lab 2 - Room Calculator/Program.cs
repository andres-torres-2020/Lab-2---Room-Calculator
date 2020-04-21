using System;

namespace Lab_2___Room_Calculator
{
    /*
     * A.TORRES
     * LAB 2 - ROOM CALCULATOR
     * 
     *    Task: Calculate the perimeter and area of various classrooms at Grand Circus
     *   What will the application do?
     *   ● 1 Point: The application prompts the user to enter values of length and width of the
     *   classroom.
     *   ● 2 Point: The application displays the area and perimeter of that classroom.
     *   ● 1 Point: The application prompts the user to continue (keep measuring rooms!).
     *   Build Specifications:
     *   ● 1 Point: Assume that the rooms are perfect rectangles.
     *   ● 1 Point: Assume that the user will enter valid numeric data for length and width.
     *   ● 1 Point: The application should accept decimal entries.
     *   Additional Requirements
     *   ● 1 Point: For answering the Lab Summary while submitting to the LMS.
     *   ● -2 Points: if there are any syntax errors or if the program does not run (for example, in a
     *   Main method).
     *   Extended Exercises:
     *   ● 1 Point: The application should continue only if the user agrees to.
     *   ● 1 Point: Calculate the volume of the rooms
     *   Hints:
     *   ● Don’t mess up the formulas for perimeter or area of a rectangle!
     *   ● The Snug is 24’6” x 20’0”. The Penthouse is 42’6” x 16’6”.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string input = "y";

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            while (input == "y")
            {
                // prompt the user to enter values of length, width and height of a classroom
                Console.WriteLine("");
                Console.Write("Enter Length: ");
                input = Console.ReadLine();
                double length = double.Parse(input);

                Console.Write("Enter Width: ");
                input = Console.ReadLine();
                double width = double.Parse(input);

                Console.Write("Enter Height: ");
                input = Console.ReadLine();
                double height = double.Parse(input);

                // compute area, perimeter and volume
                double area = length * width;
                double perimeter = 2 * (length + width);
                double volume = area * height;

                // display the area, perimeter and volume of that classroom
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine("");

                // ask user if they want to enter dimensions for another classroom
                Console.Write("Continue? (y/n) ");
                input = Console.ReadLine().Trim().ToLower();
            }
        }
    }
}
