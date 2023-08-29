using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week6
{
    class partitionS
    {
        static int partitionPossible(int n , int[] weights)
        {
            int sum = weights.Length == 1 ? weights[0] : 0;
            if(sum == 0)
            {
                for (int i = 0; i < weights.Length; i++)
                {
                    sum += weights[i];
                }
            }
            if (sum % 3 == 0)
                return 1;
            else
                return 0;
            
        }
        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
           
        //    var w = Console.ReadLine().Split(' ');
        //    int[] weights = new int[n];
        //    for (int i = 0; i < n; i++)
        //        weights[i] = int.Parse(w[i]);
        //    Console.WriteLine(partitionPossible(n, weights));
        //}
    }
}
