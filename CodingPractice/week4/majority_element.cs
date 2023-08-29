using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPractice.week4
{
    class majority_element
    {
        static int majorityElement(List<int> list, int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in list)
            {
                if (!dict.ContainsKey(item)) dict[item] = 0;
                dict[item]++;
            }
            foreach (var item in dict)
            {
                if (item.Value > n / 2)
                    return 1;
            }
            return 0;
        }
        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    Console.WriteLine(majorityElement(list2, n));
        //}
    }
}
