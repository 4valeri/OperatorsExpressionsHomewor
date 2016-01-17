using System;

class thirdDigitIs7
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        bool thirdDig = true;
        if ((n / 100) % 10 == 7)
        {
            Console.WriteLine("Third digit 7?\n{0}", thirdDig);
        }
        else
        {
            Console.WriteLine("Third digit 7?\nFalse");
        }
    }
}

