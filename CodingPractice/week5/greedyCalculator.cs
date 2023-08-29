using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week5
{
    class greedyCalculator
    {
        static void primitiveCalculator(int n)
        {
            List<int> list = new List<int>();
            Dictionary<int, int> dp = new Dictionary<int, int>();
            dp.Add(0, 0);
            int i = 1; 
            while(i<= n)
            {
                int n3 = i % 3 == 0 ?dp[i / 3] : n;
                int n2 = i % 2 == 0 ?dp[ i / 2] : n;
                int n1 = dp[i - 1];
                int min; 
                if (n3 <= Math.Min(n2, n1))
                    min = i / 3;
                else if (n2 <= Math.Min(n1, n3))
                    min = i / 2;
                else
                    min = i - 1;
                dp.Add(i, dp[min]+1);
                i++;

            }
             
            while (n > 0)
            {
                int n3 = n % 3 == 0 ? dp[n / 3] : n;
                int n2 = n % 2 == 0 ? dp[n / 2] : n;
                int n1 = dp[n - 1];
                int min;
                if (n3 <= Math.Min(n2, n1))
                    min = n / 3;
                else if (n2 <= Math.Min(n1, n3))
                    min = n / 2;
                else
                    min = n - 1;
                list.Add(n);
                n = min; 
            }
            //for( int n =2; n<=m; n++)
            //{
            //    int n3 = n % 3 == 0 ? n / 3 : n;
            //    int n2 = n % 2 == 0 ? n / 2 : n;
            //    int n1 = n - 1;
               
            //    if (n3 <= Math.Min(n2, n1))
            //        dp[n] = dp[n / 3] +1;
            //    else if (n2 <= Math.Min(n1, n3))
            //        dp[n] = dp[n / 2]+1;
            //    else if (n1 <= Math.Min(n2, n3))
            //        dp[n] = dp[n - 1]+1; 
            //   //dp[i] = Math.Min(dp[n / 3] + 1, dp[n / 2] + 1, dp[n - 1] + 1); 
            //}
           // Console.WriteLine(dp[m]);
            //while (m > 1)
            //{
            //    int n3 = m % 3 == 0 ? m / 3 : m;
            //    int n2 = m % 2 == 0 ? m / 2 : m;
            //    int n1 = m - 1;

            //    if (dp[n3] < Math.Min(dp[n2], dp[n1]))
            //    { list.Add(dp[m / 3] + 1); m = n3; }
            //    else if (dp[n2] < Math.Min(dp[n1], dp[n3]))
            //    { list.Add(dp[m / 2] + 1); m = n2; }
            //    else
            //    { list.Add(dp[m - 1] + 1); m = n1; }
            //}
            list.Reverse();
            Console.WriteLine(list.Count -1);
            foreach (var item in list)
                Console.Write(item + " ");
            
        }
        //static void Main()
        //{

        //    int n = int.Parse(Console.ReadLine());
        //    primitiveCalculator(n);
        //}
}
}
