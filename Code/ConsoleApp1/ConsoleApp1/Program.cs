using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Enter number : ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("محیط دایره: " + circumference);
        Console.WriteLine("مساحت دایره: " + area);
    }
}
