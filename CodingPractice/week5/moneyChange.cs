using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week5
{
    class moneyChange
    {
        static int moneychandeDp(int money, int[] denominations, int[] minNumCoins)
        {
            if (money == 0)
                return 0;
           
            for (int m = 1; m<= money; m++)
            {
                minNumCoins[m] = int.MaxValue;
                for (int i = 0; i < denominations.Length; i++)
                {
                    if(m>= denominations[i])
                    {
                        int numCoins = minNumCoins[m - denominations[i]];
                        if (numCoins + 1 < minNumCoins[m])
                            minNumCoins[m] = numCoins + 1;
                    }


                }
            }
            
            return minNumCoins[money];
        }
        //static void Main()
        //{
        //    int[] denominations = { 1, 3, 4 };
            
        //    int money = int.Parse(Console.ReadLine());
        //    int[] minNumCoins = new int[money+1];
        //    minNumCoins[0] = 0;
        //    Console.WriteLine(moneychandeDp(money, denominations, minNumCoins));

        //}
    }
}
