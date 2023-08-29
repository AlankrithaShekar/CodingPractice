using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.week4
{
    class binary_search
    {
        static List<int> binarySearch(long n, List<int> arr, long n2, List<int> arr2)
        {
            List<int> result = new List<int>();


            for (int i = 0; i < n2; i++)
            {
                result.Add(binarySearchIndex(arr, 0, n - 1, arr2[i]));
            }



            return result;
        }
        static int binarySearchIndex(List<int> arr, long low, long high, long x)
        {
            if (low <= high)
            {
                int mid = (int)(low + ((high - low) / 2));
                if (arr[mid] == x)
                    return mid;
                else if (x > arr[mid])
                    return binarySearchIndex(arr, mid + 1, high, x);
                else
                    return binarySearchIndex(arr, low, mid - 1, x);
            }

            return -1;
        }

        //static void Main()
        //{
        //    var listarr = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    int n = listarr[0];
        //    listarr.RemoveAt(0);

        //    var listarr2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    int n2 = listarr2[0];
        //    listarr2.RemoveAt(0);
        //    List<int> result = binarySearch(n, listarr, n2, listarr2);
        //    foreach (var item in result)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}
    }
}
