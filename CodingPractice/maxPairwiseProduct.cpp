#include <iostream>
#include <vector>
#include <string>
using namespace std;

    class maxPairwiseProduct
    {
        //static long maxPairwise(long[] arr)
        //{
        //    long max1 = 0, index = -1, max2 = 0;
        //    for(int i = 0; i<arr.Length; i++)
        //    {
        //        if (arr[i] > max1)
        //        {
        //            max1 = arr[i] ;
        //            index = i;
        //        }
        //    }
        //    for(int i = 0; i<arr.Length && i!=index; i++)
        //    {
        //        max2 = max2 > arr[i] ? max2 : arr[i];
        //    }
        //    return max1 * max2;
        //}

        //static long maxPairwise_naive(long[] arr)
        //{
        //    long max = -1;
        //    for(int i =0; i<arr.Length; i++)
        //    {
        //        for(int j = i+1; j<arr.Length; j++)
        //        {
        //            max = arr[i] * arr[j] > max ? arr[i] * arr[j] : max;
        //        }
        //    }
        //    return max;
        //}

        public:
                long maxPairwise_fast(vector<int> &nums)
                {
                    long first = 0, second = 0;
                    for (int i = 0; i < nums.size(); i++)
                    {
                        if (nums[i] > first)
                        {
                            second = first;
                            first = nums[i];
                        }
                        else if (nums[i] > second)
                        {
                            second = nums[i];
                        }
                    }
                    return first * second;
                }
        //static void stressTest(int N, int M)
        //{
        //    bool Truth = true;
        //    while (Truth)
        //    {
        //        Random rand = new Random();
        //        long n = (long)(10 * rand.Next(2, N));
        //        long[] ar = new long[n];
        //        for (int i = 0; i < n; i++)
        //        {

        //            ar[i] = (long)(10 * rand.Next(0, M));
        //            Console.Write(ar[i] + ",");
        //        }
        //        Console.WriteLine();
        //        long result1 = maxPairwise(ar);
        //        long result2 = maxPairwise_naive(ar);
        //        if (result1 == result2)
        //            Console.WriteLine("OK");
        //        else
        //        {
        //            Console.WriteLine("Wromg Answer: {0},{1}", result1, result2);
        //            Truth = false;
        //        }

        //    }
        //}
        //static void Main()
        //{
        //    //stressTest(10, 7);

        //    //var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt64);
        //    int n = int.Parse(Console.ReadLine());
        //    long[] arr = new long[n];
        //    var input = Console.ReadLine();
        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = Convert.ToInt64(input.Split(' ')[i]);
        //    }
        //    Console.WriteLine(maxPairwise_fast(arr));
        //}

    };

    //int main() {
	   //     vector<int> vec;
	   //     int n;
	   //     cin >> n;
	   //     for (int i = 0; i < n; i++)
	   //     {
	   //     	int x;
	   //     	cin >> x;
	   //     	vec.push_back(x);
	   //     }

	   //     maxPairwiseProduct m;
	   //     cout << m.maxPairwise_fast(vec) << endl;
	        
	   //     return 0;
    //    }

