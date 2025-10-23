using System;

class program
{
    static void Main()
    {
        Console.Write("لطفا دما را به سانتی گراد وارد کنید: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine("دمای معادل به فارنهایتک: " + fahrenheit); 
    }
}
