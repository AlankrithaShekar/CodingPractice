using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
    public class OddEvenArray
    {
        public int[] SegregateArray(int[] arr)
        {
            int odd = -1 , temp;
            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    odd++;
                    temp = arr[odd];
                    arr[odd] = arr[i];
                    arr[i] = temp;
                }

            }
            return arr;
        }
        public int RemoveEven(ref int[] arr)
        {
            int count = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }
            
            return count;
        }
    }
}
