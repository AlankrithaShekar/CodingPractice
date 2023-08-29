using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.week3
{
    class FracKnapsack
    {
        static double fractionalKnapsack(int n, double weight, List<double[]> loots)
        {
            double val = 0;
            for (int i = 0; i < n; i++)
            {
                loots[i][0] = loots[i][0] / loots[i][1];
            }
            loots = loots.OrderBy(x => x[0]).ToList();
            for (int i = n - 1; i >= 0; i--)
            {
                if (loots[i][1] <= weight)
                {
                    val += loots[i][1] * loots[i][0];
                    weight -= loots[i][1];

                }
                else
                {
                    val += (weight * loots[i][0]);
                    break;
                }

            }
            return Math.Round(val, 3);
        }

        
  
        //static void Main()
        //{
        //    string item = Console.ReadLine();
        //    int n = Convert.ToInt32(item.Split(' ')[0]);
        //    double weight = Convert.ToDouble(item.Split(' ')[1]);
        //    List<double[]> loots = new List<double[]>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        double[] li = new double[2];
        //        string liItem = Console.ReadLine();
        //        li[0] = Convert.ToDouble(liItem.Split(' ')[0]);
        //        li[1] = Convert.ToDouble(liItem.Split(' ')[1]);
        //        loots.Add(li);
        //    }
        //    Console.WriteLine(fractionalKnapsack(n, weight, loots));
        //}
        
       

    }
}
