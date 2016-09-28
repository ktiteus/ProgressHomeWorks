using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Dimitar Zhelyazkov");
        Console.WriteLine("1, 101, 1001");
        Console.WriteLine(Math.Sqrt(12345));


        int digit = 2;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(digit);
            if(digit > 0)
            {
                digit += 1;
                // digit +1
                digit *= -1;
                //didgit ili chislo umnozheno po -1
            }
            else
            {
                int posDigit = Math.Abs(digit);
                posDigit += 1;
                digit = posDigit;
            }

        }

    }
}
