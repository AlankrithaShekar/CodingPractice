using System;
using System.Collections.Generic;
using System.Text;


class fibonacci_sum_of_squares
{
    public static long pisano(long m)
    {
        long prev = 0;
        long curr = 1;
        long res = 0;

        for (int i = 0; i < m * m; i++)
        {
            long temp = 0;
            temp = curr;
            curr = (prev + curr) % m;
            prev = temp;

            if (prev == 0 && curr == 1)
                res = i + 1;
        }
        return res;
    }

    // Calculate Fn mod m
    public static long fibonacciModulo(long n,
                                       long m)
    {

        // Getting the period 
        long pisanoPeriod = pisano(m);

        n = n % pisanoPeriod;

        long prev = 0;
        long curr = 1;

        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;

        for (int i = 0; i < n - 1; i++)
        {
            long temp = 0;
            temp = curr;
            curr = (prev + curr) % m;
            prev = temp;
        }
        return curr % m;
    }
    public static long squareFibLastDigitSum(long n)
    {
        long sum = 0;
        long fibn = fibonacciModulo(n, 10) % 10;
        long fibprev = fibonacciModulo(n - 1, 10) % 10;
        sum = ((fibn + fibprev) * fibn) % 10;
        return sum;
    }

    //static void Main()
    //{
    //    long input = Convert.ToInt64(Console.ReadLine());
    //    Console.WriteLine(squareFibLastDigitSum(input));
    //}
    }

