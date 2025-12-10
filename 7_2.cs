using System;

class Program
{
    static double ConvertTemperature(double celsius)
    {
        double fahrenheit = celsius * 9 / 5 + 32;
        return fahrenheit;
    }

    static void Main()
    {
        double t0 = ConvertTemperature(0);
        double t20 = ConvertTemperature(20);
        double t100 = ConvertTemperature(100);

        Console.WriteLine("0C = " + t0 + "F");
        Console.WriteLine("20C = " + t20 + "F");
        Console.WriteLine("100C = " + t100 + "F");
    }
}
