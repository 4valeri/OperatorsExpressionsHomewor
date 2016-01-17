using System;

class oddOrEvenIntegers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool even = n % 2 != 0;
        bool odd = n % 2 != 1;

        if (odd == even)
        {
            Console.WriteLine(odd);
        }
        else
        {
            Console.WriteLine(even);
        }
    }
}

