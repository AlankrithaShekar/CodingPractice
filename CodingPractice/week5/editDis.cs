using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week5
{
    class editDis
    {
        static int editDistance(char[] input1 , char[] input2)
        {
            int m = input1.Length, n = input2.Length;
            int[,] D = new int[m+1,n+1];
           
            for(int i = 0; i<=m; i++)
            {
                for(int j =0; j<=n; j++)
                {
                    if (i == 0 || j == 0)
                        D[i, j] = 0; 
                    int insert = D[i, j - 1] + 1;
                    int delete = D[i - 1, j] + 1;
                    int match = D[i - 1, j - 1];
                    int mismatch = D[i - 1, j - 1] + 1;
                    if (input1[i-1] == input2[j-1])
                        D[i, j] = min(insert, delete, match);
                    else
                        D[i, j] = min(insert, delete, mismatch);
                }
            }
            return D[m, n];
        }
        static int min(int a , int b, int c)
        {
            if (a <= Math.Min(b, c))
                return a;
            else if (b <= Math.Min(a, c))
                return b;
            else
                return c; 
        }
        //static void Main()
        //{
        //    string input1 = Console.ReadLine();
        //    string input2 = Console.ReadLine();
        //    Console.WriteLine(editDistance(input1.ToCharArray(), input2.ToCharArray()));
        //}
    }
}
