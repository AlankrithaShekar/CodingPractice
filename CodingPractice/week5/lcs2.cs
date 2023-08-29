using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week5
{
    class lcs2
    {
        static int longestCommonSubSequence(int[] X, int[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1]; 
            for(int i =0; i<=m; i++)
            {
                for(int j =0; j<= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
            //if (m == 0 || n == 0)
            //    return 0;
            //if (X[m - 1] == Y[n - 1])
            //    return 1 + longestCommonSubSequence(X, Y, m - 1, n - 1);
            //else
            //    return  Math.Max(longestCommonSubSequence(X, Y, m, n - 1), longestCommonSubSequence(X, Y, m - 1, n));
        }
        //static void Main()
        //{
        //    int m = int.Parse(Console.ReadLine());
        //    int[] X = new int[m];
        //    var read = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < m; i++)
        //        X[i] = int.Parse(read[i]);
        //    int n = int.Parse(Console.ReadLine());
        //    int[] Y = new int[n];
        //    var read1 = Console.ReadLine().Split(' ');
        //    for (int i = 0; i < n; i++)
        //        Y[i] = int.Parse(read1[i]);
        //    Console.WriteLine(longestCommonSubSequence(X, Y, m, n));
        //}
    }
}
