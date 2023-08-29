//using System;
//using System.Collections.Generic;
//using System.Text;


//class fibonacci_sum
// {
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
//            {
//                res = i + 1;
//                return res;
//            }
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
//    public static long fibLastDigitSum(long n)
//    {
//        long pisanoPeriod = pisano(10);
//        int lastPisanoOccurence;
//        int numberOfPisanoOccurence;
//        for (int i = 0; i < m; i++)
//        {
//            if (pisanoPeriod * i > n)
//            {
//                lastPisanoOccurence = (pisanoPeriod * (i - 1));
//                numberOfPisanoOccurence = i - 1;
//                break;
//            }
//        }
//        long sum = 0;
//        for (int i = 0; i <= pisanoPeriod; i++)
//        {
//            sum += fibonacciModulo(i, 10);
//            sum %= 10;
//        }
//        sum *= numberOfPisanoOccurence;
//        sum %= 10;
//        int leftNumbers = n - lastPisanoOccurence;
//        for (int i = 0; i <= leftNumbers; i++)
//        {
//            sum += fibonacciModulo(i, 10);
//            sum %= 10;
//        }
//        return sum;
//    }
//    //static void Main()
//    //{
//    //    long input = Convert.ToInt64(Console.ReadLine());
//    //    Console.WriteLine(fibLastDigitSum(input));
//    //}
//    }

