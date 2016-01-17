using System;

class divideBy7and5
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int dividedBy5 = n % 5;
        int dividedBy7 = n % 7;
        int dividedBy35 = n % 35;

        bool loginc = dividedBy35 == 0 && 
            dividedBy5 == 0 &&
            dividedBy7 == 0;


        Console.WriteLine(loginc);

    }
}
