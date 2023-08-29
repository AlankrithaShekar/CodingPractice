using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week6
{
    class maxGold
    {
        static int maxAmountGold(int[] weights, int maxTotal)
        {
            int[,] values = new int[weights.Length + 1, maxTotal + 1];
            for(int i  =0; i<= weights.Length; i++)
            {
                values[i, 0] = 0;
            }
            for (int w = 0; w <= maxTotal; w++)
            {
                values[0, w] = 0;
            }
            for (int i = 1; i <= weights.Length; i++)
            {
                for (int w = 1; w <= maxTotal; w++)
                {
                    values[i, w] = values[i - 1, w];
                    if(weights[i-1]<= w)
                    {
                        int val = values[i - 1, w - weights[i-1]] + weights[i-1];
                        if (values[i, w] < val)
                        {
                            values[i, w] = val;
                        }
                    }
                }
            }
            return values[weights.Length,maxTotal];
        }
        //static void Main()
        //{
        //    var input = Console.ReadLine().Split(' ');
        //    int maxTotal = int.Parse(input[0]);
        //    int weightCount = int.Parse(input[1]);
        //    var w = Console.ReadLine().Split(' ');
        //    int[] weights = new int[weightCount];
        //    for (int i = 0; i < weightCount; i++)
        //        weights[i] = int.Parse(w[i]);
        //    Console.WriteLine(maxAmountGold(weights, maxTotal));
        //}
    }
}
