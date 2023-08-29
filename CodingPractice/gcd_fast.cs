using System;
using System.Collections.Generic;
using System.Text;


class gcd_fast
    {
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
    //public static void Main(string[] args)
    //{
    //    string n = Console.ReadLine();
    //    long a = Convert.ToInt64(n.Split(' ')[0]);
    //    long b = Convert.ToInt64(n.Split(' ')[1]);

    //    Console.WriteLine(get_gcd_fast(a, b));
    //}
}

