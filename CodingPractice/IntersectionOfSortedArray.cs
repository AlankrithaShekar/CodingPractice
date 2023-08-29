using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace CodingPractice
{
    class IntersectionOfSortedArray
    {
        public static int[] IntersectionSortedArray(int[] a, int[] b)
        {
            HashSet<int> set = new HashSet<int>(a);
            HashSet<int> result = new HashSet<int>();
            foreach(var x in b)
            {
                if (set.Contains(x))
                    result.Add(x);

            }
            return result.ToArray();

        }
        //public static int[] IntersectionSortedArray(int[] a, int[] b)
        //{
        //    List<int> intersect = new List<int>();
        //    int j = 0;
        //    while (j < b.Length)
        //    {
        //        int i = 0; 
        //        while (i < a.Length)
        //        {
        //            if (a[i] == b[j])
        //            {
        //                intersect.Add(a[i]);
        //                break;
        //            }
        //            else if (a[i] > b[j])
        //            {
        //                break;
        //            }
        //            i++;
        //        } 
        //        j++;

        //    }
        //    return intersect..ToArray(); 
        //}
    }
}
