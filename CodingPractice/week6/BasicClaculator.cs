using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.week6
{
    class BasicClaculator
    {
        public static int Calculate(string s)
        {
            int res = 0;
            int num = 0;
            int sign = 1 ;
            Stack<int> st = new Stack<int>();
            for(int i = 0; i<s.Length; i++)
            {
                var x = s[i];
                if (x == '+')
                {
                    sign = 1;
                }
                else if (x == '-')
                {
                    sign = -1;
                }
                else if (x == '(')
                {
                    st.Push(res);
                    st.Push(sign);
                    res = 0;
                    sign = 1;
                }
                else if (x == ')')
                {
                    res = res * st.Pop() + st.Pop();
                }
                else if (char.IsDigit(s[i]))
                {
                    num = 0;  
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        num = num * 10 + s[i++] - '0'; 
                    }
                    i--;
                    res += num * sign;
                }
            }
            
            return res;
        }

        //public static void Main()
        //{
        //    var mat = new int[3][];
        //    mat[0] = new int[] { 1,2};
        //    mat[1] = new int[] { 3, 4 };
        //    mat[2] = new int[] { 5, 6 };
        //    Console.WriteLine(MatrixReshape(mat, 2,3));
        //    //Console.WriteLine(MinDeletions("bbcebab"));
        //    //Console.WriteLine(Calculate("(1+(4+5+2)-3)+(6+8)"));
        //}

        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int row = mat.Length;
            int col = mat[0].Length;
            if (row * col != r * c) return mat;

            int[][] result = new int[r][];
            int rn = 0, cn = 0;

            result[rn] = new int[c];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[rn][cn] = mat[i][j];
                    cn++;
                    if (cn == c)
                    {
                        cn = 0;
                        rn++;
                        if(rn < r)
                         result[rn] = new int[c];
                    }
                }
            }
            return result;
        }

        public static int MinDeletions(string s)
        {
            int[] f = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                f[s[i] - 'a']++;
            }
            Array.Sort(f);
            Array.Reverse(f);
            int count = 0;
            int mf = f[0] - 1;
            for (int i = 1; i < 26 && f[i]!=0; i++)
            {
                if (f[i] <= mf)
                {
                    mf = f[i]-1;
                }
                else
                {
                    count += (f[i] - mf);
                    if (mf > 0)
                    {
                        mf--;
                    }
                }
            }
            return count;
        }
    }
}
