using System;

class fourDigitNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstDigit = n % 10;
        int secondDIgit = (n /10) % 10;
        int thirdDigit = (n / 100) % 10;
        int fourthDigit = (n / 1000) % 10;

        int sumOfDigits = firstDigit + secondDIgit + thirdDigit + fourthDigit;
        int reversed;

        Console.WriteLine("Sum of digits: {0}", sumOfDigits);
        Console.WriteLine("Reversed : {3}{2}{1}{0}", fourthDigit,
            thirdDigit,
            secondDIgit,
            firstDigit);
        Console.WriteLine("Last digit in front: {1}{0}{3}{2}", fourthDigit,
            firstDigit,
            secondDIgit,
            thirdDigit);
        Console.WriteLine("Second and third digits exchanged: {0}{2}{3}{1}", fourthDigit,
            firstDigit,
            secondDIgit,
            thirdDigit);
    }
}

