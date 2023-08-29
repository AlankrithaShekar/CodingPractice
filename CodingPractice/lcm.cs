using System;
using System.Collections.Generic;
using System.Text;


class lcm
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
    public static long lcm_fast(long a, long b)
    {
        long gcd = get_gcd_fast(a, b);


        long lcm = (a) * (b / gcd);
        return lcm;
    }
    //static void Main()
    //{
    //    string n = Console.ReadLine();
    //    long a = Convert.ToInt64(n.Split(' ')[0]);
    //    long b = Convert.ToInt64(n.Split(' ')[1]);
    //    Console.WriteLine(lcm_fast(a, b));

    //}
}

