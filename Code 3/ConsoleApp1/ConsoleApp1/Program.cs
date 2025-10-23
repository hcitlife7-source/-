using System;

class program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number < 1)
        {
            Console.WriteLine("TRUE !");
        }
    }
}