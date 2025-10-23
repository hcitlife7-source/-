using System;

class program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 3 == 0 )
        {
            Console.WriteLine("Yes !");
        }
        else
        {
            Console.WriteLine(number * 3);
        }
    }
}