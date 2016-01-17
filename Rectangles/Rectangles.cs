using System;

class Rectangles
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int area = width * height;
        int perimeter = (width + height) * 2;

        Console.WriteLine("Perimeter= {0}\nArea= {1}", perimeter,
            area);
    }
}

