using System;

class primeNumberCheck
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
                   
            Console.WriteLine("Prime?\nflase");

            return;
        
        }

        bool isPrime = n % n == 0 && n % 2 == 1;
        

        if (n == 2)
        {
            Console.WriteLine("Prime?\ntrue");
        }
        else
        {
            Console.WriteLine("Prime?\n{0}", isPrime);
        }
    }
}

