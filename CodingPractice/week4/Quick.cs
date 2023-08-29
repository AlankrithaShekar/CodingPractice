using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.week4
{
    class Quick
    {
        public int[] A; //Array which has to be sorted

        public Quick(int[] array)  //Constructor
        {
            A = array;
        }

        public int[] Sort()
        {
            QuickSort(0, A.Length - 1);
            return A;
        }

        void Swap(int i, int j)     //Swaps values of two indexes
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        //Recursion
        public void QuickSort(int p, int r) {
            if (p < r)
            {
                int q = Partition(p, r);
                QuickSort(p, q - 1);
                QuickSort(q + 1, r);
            }
        }

        //Gives index where to part the array as well as sorts
        public int Partition(int p, int r) {
            int pivot = A[r];  //always last element
            int i = p - 1;
            for (int j = p; j < r; j++)
            {
                if (A[j] < pivot)
                {
                    i++;
                    Swap(i, j);
                }
            }
            i++;
            Swap(i, r);
            return i;
        }
        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //    Quick quick = new Quick(arr);
        //    var sortedArr = quick.Sort();
        //    foreach (var item in sortedArr)
        //        Console.Write(item + " ");
        //}
    }
}
