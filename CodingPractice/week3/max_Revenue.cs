using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week3
{
    class max_Revenue
    {
        static long maxRevenue(int n, long[] profits, long[] clicks)
        {
            long revenue = 0;
            Array.Sort(profits);
            Array.Sort(clicks);
            for (int i = 0; i < n; i++)
            {
                revenue += profits[i] * clicks[i];
            }
            return revenue;
        }

        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    long[] profits = new long[n];
        //    long[] clicks = new long[n];
        //    string profit = Console.ReadLine();
        //    string click = Console.ReadLine();
        //    for (int i = 0; i < n; i++)
        //    {
        //        profits[i] = Convert.ToInt64(profit.Split(' ')[i]);
        //        clicks[i] = Convert.ToInt64(click.Split(' ')[i]);
        //    }
        //    Console.WriteLine(maxRevenue(n, profits, clicks));
        //}
    }
}
