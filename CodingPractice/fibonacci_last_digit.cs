using System;
using System.Collections.Generic;
using System.Text;

class fibonacci_last_digit
    {
    public static int get_fibonacci_last_digit(int n)
    {
        if (n <= 1)
            return 1;
        int[] fib = new int[n];
        fib[0] = fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = (fib[i - 1] + fib[i - 2]) % 10;
        }

        return fib[n - 1] % 10;
    }
    //static void Main()
    //{
    //   int n = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine(get_fibonacci_last_digit(n));
        
    //}
}

