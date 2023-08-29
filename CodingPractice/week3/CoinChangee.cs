using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week3
{
    class CoinChangee
    {
        static int MinimumCoins(int n)
        {
            int[] nums = { 1, 5, 10 };
            int coins = 0;
            for (int i = nums.Length - 1; i >= 0 && n > 0; i--)
            {
                int f = n / nums[i];
                coins += f;
                n -= (nums[i] * f);
            }
            return coins;
        }

        //static void Main()
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(MinimumCoins(n));
        //}
    }
}
