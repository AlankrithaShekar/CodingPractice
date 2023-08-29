/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
    public static int fibonacci_fast(int n)
    {
        if (n <= 1)
            return 1;
        // write your code here
        int[] fib = new int[n];
        fib[0] = fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }


        return fib[n - 1];
    }
    public static int get_fibonacci_last_digit(int n)
    {
        if (n <= 1)
            return 1;
        // write your code here
        int[] fib = new int[n];
        fib[0] = fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = (fib[i - 1] + fib[i - 2]) % 10;
        }

        return fib[n - 1] % 10;
    }
    public static long get_gcd_fast(long a, long b)
    {

        if (b == 0)
            return a;
        if (a < b)
        {
            long temp = a;
            a = b;
            b = temp;
        }
        else
            a = a % b;
        return get_gcd_fast(a, b);

    }
    public static long lcm_fast(long a, long b)
    {
        long gcd = get_gcd_fast(a, b);


        long lcm = (a / gcd) * (b / gcd);
        return lcm;
    }
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
    public static long fibLastDigitSum(long n)
    {
        long sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += fibonacciModulo(i, 10);
            sum %= 10;
        }
        return sum;
    }
    public static long partialFibLastDigitSum(int m, int n)
    {
        long sum = fibonacciModulo(m, 10);
        for (int i = m + 1; i <= n; i++)
        {
            sum += fibonacciModulo(i, 10);
            sum %= 10;
        }
        return sum;
    }
    public static long squareFibLastDigitSum(int n)
    {
        long sum = 0;
        long fibn = fibonacciModulo(n, 10) % 10;
        long fibprev = fibonacciModulo(n - 1, 10) % 10;
        sum = ((fibn + fibprev) * fibn) % 10;
        return sum;
    }

    //static void Main()
    //{
    //    int input = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine(squareFibLastDigitSum(input));
    //    // Console.WriteLine(fibLastDigitSum(input));
    //    //int m = Convert.ToInt32(input.Split(' ')[0]);
    //    //int n = Convert.ToInt32(input.Split(' ')[1]);
    //    //Console.WriteLine(partialFibLastDigitSum(m,n));
    //    //Console.WriteLine(fibonacciModulo(n, m));
    //    //Console.WriteLine (lcm_fast (a, b));
    //    //Console.WriteLine(get_gcd_fast(a,b));
    //    //Console.WriteLine(get_fibonacci_last_digit(n));
    //    //Console.WriteLine(fibonacci_fast(n));
    //}
}
