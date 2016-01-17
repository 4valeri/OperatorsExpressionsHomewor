using System;

class gravitationOnTheMoon
{
    static void Main(string[] args)
    {
        double weight = double.Parse(Console.ReadLine());
        decimal weightOnTheMoon = 17m / 100m;

        weightOnTheMoon *= (decimal)weight;

        Console.WriteLine(weightOnTheMoon);
    }
}

