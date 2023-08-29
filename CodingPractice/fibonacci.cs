using System;
using System.Collections.Generic;
using System.Text;


class fibonacci
    {
    public static int fibonacci_fast(int n)
    {
        if (n == 1)
            return 1;
        if (n == 0)
            return 0;
        // write your code here
        int[] fib = new int[n];
        fib[0] = fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }


        return fib[n - 1];
    }
    //static void Main()
    //{
    //    int n = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine(fibonacci_fast(n));
    //}
}

