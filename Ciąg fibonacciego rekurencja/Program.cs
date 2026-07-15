using System;
class Program
{
    static long Fibonacci(int n)
    {

        if(n == 1)
        {
            return 0;
        } else if(n == 2)
        {
            return 1;
            

        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main()
    {
        Console.WriteLine("Podaj n: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Console.Write($"{Fibonacci(i + 1),4}" + " ");
        }

    }
}
