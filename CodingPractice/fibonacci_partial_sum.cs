//using System;
//using System.Collections.Generic;
//using System.Text;

//class fibonacci_partial_sum
//{
//    public static long pisano(long m)
//    {
//        long prev = 0;
//        long curr = 1;
//        long res = 0;

//        for (int i = 0; i < m * m; i++)
//        {
//            long temp = 0;
//            temp = curr;
//            curr = (prev + curr) % m;
//            prev = temp;

//            if (prev == 0 && curr == 1)
//                res = i + 1;
//        }
//        return res;
//    }

//    // Calculate Fn mod m
//    public static long fibonacciModulo(long n,
//                                       long m)
//    {

//        // Getting the period 
//        long pisanoPeriod = pisano(m);

//        n = n % pisanoPeriod;

//        long prev = 0;
//        long curr = 1;

//        if (n == 0)
//            return 0;
//        else if (n == 1)
//            return 1;

//        for (int i = 0; i < n - 1; i++)
//        {
//            long temp = 0;
//            temp = curr;
//            curr = (prev + curr) % m;
//            prev = temp;
//        }
//        return curr % m;
//    }
//    public static long partialFibLastDigitSum(long m, long n)
//    {
//        long sum = fibonacciModulo(m, 10);
//        for (int i = m + 1; i <= n; i++)
//        {
//            sum += fibonacciModulo(i, 10);
//            sum %= 10;
//        }
//        return sum;
//    }

//    //static void Main()
//    //{
//    //    string input = Console.ReadLine();
//    //    long m = Convert.ToInt64(input.Split(' ')[0]);
//    //    long n = Convert.ToInt64(input.Split(' ')[1]);
//    //    Console.WriteLine(partialFibLastDigitSum(m, n));
//    //}

//    }
