using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week3
{
    class carFuel
    {
        static int carFueling(int distance, int capacity, int n, int[] stops)
        {
            int stop = 0; int fuel = capacity; int count = 0;
            for (int i = 0; i <= n; i++)
            {
                int dist = (stops[i + 1] - stops[i]);
                if (dist > fuel)
                {
                    fuel = capacity;
                    count++;
                    stop = stops[i];
                   // Console.WriteLine(stop);
                }
                if (dist > capacity)
                    return -1;
                fuel -= dist;

            }
            if (fuel >= 0)
                return count;
            else
                return -1;
           
        }
        //static void Main()
        //{
        //    int distance = int.Parse(Console.ReadLine());
        //    int capacity = int.Parse(Console.ReadLine());
        //    int n = int.Parse(Console.ReadLine());
        //    int[] stops = new int[n + 2];
        //    stops[0] = 0;
        //    stops[n + 1] = distance;
        //    string stopString = Console.ReadLine();
        //    for (int i = 1; i <= n; i++)
        //    {
        //        stops[i] = int.Parse(stopString.Split(' ')[i - 1]);
        //    }
        //    Console.WriteLine(carFueling(distance, capacity, n, stops));
        //}

    }
}
