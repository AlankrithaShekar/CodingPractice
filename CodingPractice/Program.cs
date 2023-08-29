using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 4 };
            GetMaxLen(nums);

            char[][] board = new char[3][];
            board[0] = new char[] {'A','B','C','E' };
            board[1] = new char[] { 'S','F','C','S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };
            Exist(board, "SEE");

            int[] newInterval = { 2, 5 };
            int[][] intervals = new int[2][];
            intervals[0] = new int[]{ 1, 3};
            intervals[1] = new int[] { 6,9};
            Insert(intervals, newInterval);
            MinWindow("bbaa", "aba");

            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            ReorderLogFiles(logs);
            LFUCache lfu = new LFUCache(2);
            lfu.Put(2, 1);
            lfu.Put(3, 2);
            lfu.Get(3);
            lfu.Get(2);
            lfu.Put(4, 3);
            lfu.Get(2);
            lfu.Get(3);
            lfu.Get(4);
           


            LRUCache lru = new LRUCache(10);
            lru.Put(10, 13);
            lru.Put(3,17);
            lru.Put(6,11);
            lru.Put(10,5);
            lru.Put(9,10);
            Console.WriteLine(lru.Get(13));
            lru.Put(2,19);

            HashMap<int,int> hm = new HashMap<int, int>();
           // hm.ContainsKey(-2);
            hm.Put(1, 4);
            hm.Put(2, 3);
            //Console.WriteLine(hm.Get(2));
            hm.Put(3, 5);
            hm.Put(6, 7);
            hm.Put(8, 9);
            hm.Put(10, 5);
            hm.Put(11, 7);
            hm.Put(12, 9);
            hm.Put(13, 5);
            hm.Put(16, 7);
            hm.Put(18, 9);
            hm.Remove(2);
            hm.KeySet();
            hm.Remove(0);

            var processing = new List<List<string>>();
            processing.Add(new List<string>() { "INSERT", "GT23513413" });
            processing.Add(new List<string>() { "INSERT", "TQC2451340" });
            processing.Add(new List<string>() { "SHIP", "-" });
            processing.Add(new List<string>() { "INSERT", "VYP8561991" });
            processing.Add(new List<string>() { "INSERT", "VYP8561991" });
            processing.Add(new List<string>() { "SHIP", "-" });
            processing.Add(new List<string>() { "INSERT", "TQC2451340" });
            processing.Add(new List<string>() { "SHIP", "-" });
            processing.Add(new List<string>() { "INSERT", "TQC2451340" });
            processing.Add(new List<string>() { "SHIP", "-" });
            //Console.WriteLine(InsertShip(processing));

          //  int[] nums = { 8, 2, 4, 7 };
            // Console.WriteLine(LongestSubarray(nums, 4));
            int[] daysShippment = { 4, 3, 2, 3, 3 };
            // Console.WriteLine(noOfDaysShipment(daysShippment));
           // Console.WriteLine(maxDiffFreq("aabbbcacba"));
            int[] subarrayRange = { 3,1,2,4 };
            // Console.WriteLine(subArrayRanges(subarrayRange));
            int[] ranks = { 4, 1, 3, 2 };
            // Console.WriteLine(studentRanks(ranks));

            //scatterPalindrome("aabb");
            List<int> num = new List<int>() { 4, 5, 6, 7 };
            //getEncryptedNumber(num);

            char[][] jagged_arr = new char[9][];
            jagged_arr[0] = new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            jagged_arr[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            jagged_arr[2] = new char[] { '.', '3', '8', '.', '.', '.', '.', '6', '.' };
            jagged_arr[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            jagged_arr[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            jagged_arr[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            jagged_arr[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            jagged_arr[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            jagged_arr[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

            //IsValidSudoku(jagged_arr);

            TreeNode t = new TreeNode();
            t.val = 1;
            t.left = new TreeNode(2);
            t.right = new TreeNode(3);
            t.left.left = new TreeNode(4);
            t.left.right = new TreeNode(5); 
            Tree tree = new Tree();
            //tree.serialize(t, "");
            tree.deserialize("1,2,NULL,NULL,3,4,NULL,NULL,5,NULL,NULL");

            Console.WriteLine(tree.PostorderTraversal(t));
            
            //Trie trie = new Trie();
            //trie.majorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            //trie.Insert("");
            //Console.WriteLine(trie.Search("nanda"));
            //trie.Insert("a");
            //Console.WriteLine(trie.StartsWith("ala"));
            //Console.WriteLine(trie.Commonprefix());
           // Console.WriteLine(trie.LongestCommonPrefix(new string[] { "ab","a"}));
           // IntersectionOfSortedArray.IntersectionSortedArray(new int[] { 3,4, 4, 4, 5,5, 6, 7 , 22, 100},new int[] {1, 2, 3, 4, 5 , 100});
        }

        public static int GetMaxLen(int[] nums)
        {
            int l = 0, r = 0, max = 0, sign =1;
            int ln = -1, rn = -1;
            while (r < nums.Length)
            {
                if (nums[r] > 0 || (nums[r]<0 &&sign < 0))
                {
                    max = Math.Max(max, r - l + 1);
                    sign = 1;
                }
                else if (nums[r] == 0 && l + 1 < nums.Length)
                {
                    l = r + 1;
                    ln = -1;
                    rn = -1;
                }
                else
                {
                    sign *= -1;
                    if (ln == -1)
                        ln = r;
                    rn = r;
                }
                r++;
            }
            if (ln != -1)
            {
                var lefti = r - ln-1;
                var leftj = ln - l;
                max = Math.Max(max,Math.Max(leftj, lefti));
            }
            if (rn != -1)
            {
                var righti = rn - l;
                var rightj = r - rn;
                max = Math.Max(max,Math.Max(rightj, righti));
            }
            return max;
        }
        public static bool Exist(char[][] board, string word)
        {
            //int index = 0;
            bool[,] visited = new bool[board.Length, board[0].Length];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (DFS(board, word, 0, i, j, visited))
                        return true;
                }
            }
            return false;
        }
        public static bool DFS(char[][] board, string word, int index, int i, int j, bool[,] visited)
        {
            if (index == word.Length)
                return true;
            if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || visited[i, j] || board[i][j] != word[index])
                return false;
            visited[i, j] = true;
            var find = DFS(board, word, index + 1, i + 1, j, visited) || DFS(board, word, index + 1, i, j + 1, visited) || DFS(board, word, index + 1, i - 1, j, visited) || DFS(board, word, index + 1, i, j - 1, visited);
            visited[i, j] = false;

            return find;
        }
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> list = new List<int[]>();
            int[] temp = { intervals[0][0], intervals[0][1] };
            for (int i = 1; i < intervals.Length; i++)
            {
                int[] curr = intervals[i];
                if (curr[1] > newInterval[0] && curr[0] >  newInterval[0])
                {
                    temp[0] = Math.Min(temp[0], newInterval[0]);
                    temp[1] = Math.Max(temp[1], newInterval[1]);
                    list.Add(temp);
                }
                else
                {
                    list.Add(curr);
                }
                    
            }
            return list.ToArray();
        }
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            while (s.Length > 0)
            {
                var initlen = s.Length;
                foreach (var word in wordDict)
                {
                    if (s.StartsWith(word))
                    {
                        s = s.Substring(word.Length, s.Length - word.Length);
                    }
                }
                if (s.Length == initlen)
                    return false;
            }
            return true;
        }
        public static string MinWindow(string s, string t)
        {
            if (t.Length > s.Length || t == "")
                return "";
            if (t.Length == s.Length && s == t)
                return s;
            int[] index = { -1, -1 };
            int min = Int32.MaxValue;
            Dictionary<char, int> tfreq = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (!tfreq.ContainsKey(t[i]))
                    tfreq[t[i]] = 0;
                tfreq[t[i]]++;
            }
            Dictionary<char, int> sfreq = new Dictionary<char, int>();
            int left = 0, right = 0, need = tfreq.Count, have = 0;
            while (right < s.Length)
            {
                if (tfreq.ContainsKey(s[right]))
                {
                    if (!sfreq.ContainsKey(s[right]))
                        sfreq[s[right]] = 0;
                    sfreq[s[right]]++;
                    if (sfreq[s[right]] == tfreq[s[right]])
                        have++;
                }
                while (need == have)
                {
                    if (min > right - left + 1)
                    {
                        min = right - left + 1;
                        index[0] = left;
                        index[1] = right;
                    }

                    if (sfreq.ContainsKey(s[left]))
                    {
                        sfreq[s[left]]--;
                        if (sfreq[s[left]] == 0)
                            sfreq.Remove(s[left]);
                        if (tfreq.ContainsKey(s[left]) && sfreq.GetValueOrDefault(s[left]) < tfreq[s[left]])
                            have--;
                    }
                    left++;
                }
                right++;
            }
            if (index[0] == -1)
                return "";
            return s.Substring(index[0], index[1] - index[0] + 1);
        }
       
        public int LengthOfLongestSubstring(string s)
        {
            int left = 0, right = 0;
            int max = 0;
            HashSet<char> hash = new HashSet<char>();
            while (right < s.Length)
            {
                if (!hash.Contains(s[right]))
                    hash.Add(s[right]);
                else
                {
                    hash.Remove(s[left]);
                    left++;
                }
                right++;
                max = Math.Max(max, right - left);
            }
            return max;
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            //Dictionary<string, SortedSet<string>> sd = new Dictionary<string, SortedSet<string>>();
            Dictionary<string, List<string>> sd = new Dictionary<string, List<string>>();
            List<string> digits = new List<string>();
            var result = new List<string>();

            for (int i = 0; i < logs.Length; i++)
            {
                var id = logs[i].Substring(0, logs[i].IndexOf(' ') + 1);
                var content = logs[i].Substring(logs[i].IndexOf(' ') + 1);
                if (content[0] >= 'a' && content[0] <= 'z')
                {
                    if (!sd.ContainsKey(id))
                        sd.Add(id, new List<string>());
                    sd[id].Add(content);
                }
                else
                {
                    digits.Add(logs[i]);
                }
            }

            //sd = sd.Select(x => x.Value).OrderBy(x =>x.Sort()).ThenBy(y => y.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in sd)
            {
                foreach (var i in item.Value)
                    result.Add(item.Key + i);

            }
            foreach (var item in digits)
                result.Add(item);

            return result.ToArray();
        }

        public static List<List<string>> InsertShip(List<List<string >> processing)
        {
            Queue<string> q = new Queue<string>();
            int count = 0; 
            List<List<string>> output = new List<List<string>>();
            for(int i =0; i<processing.Count; i++)
            {
                var cmd = processing[i][0];
                var item = processing[i][1];

                if (cmd == "INSERT")
                {
                    q.Enqueue(item);
                    count++;
                }
                else if(cmd =="SHIP")
                {
                    if (count >= 3)
                    {
                        List<string> items = new List<string>();
                        int counter = 1; 
                        while(counter<=3)
                        {
                            items.Add(q.Dequeue());
                            counter++;
                        }
                        count -= 3;
                        output.Add(items);
                    }
                    else
                    {
                        output.Add(new List<string>(){"N/A"});
                    }
                }

            }
            return output;
        }
        public static int LongestSubarray(int[] A, int limit)
        {
            List<int> listMax = new List<int>();
            List<int> listMin = new List<int>();
            int i = 0;
            int j = 0;
            int Result = 0;
            while (j < A.Length)
            {
                AddListMax(listMax, A[j]);
                AddListMin(listMin, A[j]);
                int Max = listMax[0];
                int Min = listMin[0];
                if (Max - Min <= limit)
                {
                    Result = Math.Max(Result, j - i + 1);
                    j++;
                }
                else if (Max - Min > limit)
                {
                    while (Max - Min > limit)
                    {
                        if (listMax[0] == A[i])
                        {
                            listMax.RemoveAt(0);
                        }
                        if (listMin[0] == A[i])
                        {
                            listMin.RemoveAt(0);
                        }
                        Max = listMax[0];
                        Min = listMin[0];
                        i++;
                    }
                    j++;
                }
            }
            return Result;
        }
        public static void AddListMax(List<int> list, int n)
        {
            while (list.Count > 0 && list[list.Count - 1] < n)
            {
                list.RemoveAt(list.Count - 1);
            }
            list.Add(n);
        }

        public static void AddListMin(List<int> list, int n)
        {
            while (list.Count > 0 && list[list.Count - 1] > n)
            {
                list.RemoveAt(list.Count - 1);
            }
            list.Add(n);
        }
        public static int noOfDaysShipment(int[] arr)
        {
            int days = 1; 
            Array.Sort(arr);
            int count = arr[0];
            for(int i =1; i<arr.Length; i++)
            {
                if(arr[i]-count != 0)
                {
                    count += (arr[i] - count);
                    days++;
                }
            }
            return days; 
        }

        //public static int maxDiffFreq(string s)
        //{
        //    int ans = 0;
        //    List<(int,int)> memo = new List<(int,int)>();
        //    Dictionary<int,int> c = new Dictionary<int, int>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        c.Clear();
        //        for (int v = i; v < Math.Min(s.Length, i + ans + 1); v++)
        //        {
        //            if (!c.ContainsKey(s[v]))
        //                c[s[v]] = 0;
        //            c[s[v]]++;
        //        }
        //        for (int j = i + 1 + ans + 1; j < s.Length; j++)
        //        {
        //            c[s[j]] += 1;
        //            int max = c.Max(x => x.Value);
        //            if (max < ans + 1)
        //                continue;
        //            int min = c.Min(x => x.Value);
        //            var h = (max, min);
        //            if (memo.Contains(h))
        //                continue;
        //            memo.Add(h);
        //            ans = Math.Max(ans, max - min);
        //        }

        //    }


        //    return ans; 
        //    //int min = int.MaxValue, max = int.MinValue;
        //    //int[] freq = new int[26];
        //    //for(int i =0; i<s.Length; i++)
        //    //{
        //    //    freq[s[i] - 'a']++;
        //    //}
        //    //for(int i =0; i<26; i++)
        //    //{
        //    //    if (freq[i] != 0)
        //    //    {
        //    //        min = Math.Min(min, freq[i]);
        //    //        max = Math.Max(max, freq[i]);
        //    //    }
        //    //}
        //    //return max-min; 

        //}
        public static long MinimumHealth(int[] damage, int armor)
        {
            int sum = 0, max = int.MinValue;
            for (int i = 0; i < damage.Length; i++)
            {
                sum += damage[i];
                max = Math.Max(max, damage[i]);
            }
            sum -= max;
            if (max > armor)
                max = max - armor;
            else
                max = 0;
            return sum + max + 1;
        }
        public static int uniqueLetterString(string s)
        {
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                total += (s.Length - i) * (s.Length - i + 1) / 2;
                if (s.LastIndexOf(s[i], i - 1) != -1)
                    total -= (s.Length - i) * (s.LastIndexOf(s[i], i - 1) + 1);
            }
            return total;
        }
        public static long subArrayRanges(int[] A)
        {
            int n = A.Length;
            int j, k; 
            long res = 0;
            Stack<int> s = new Stack<int>();
            for (int i = 0; i <= n; i++)
            {
                while (s.Count > 0 && A[s.Peek()] > (i == n ? int.MinValue : A[i]))
                {
                    j = s.Pop();
                    k = s.Count == 0 ? -1 : s.Peek();
                    res -= (long)A[j] * (i - j) * (j - k);

                }
                s.Push(i);

            }
            s.Clear();
            for (int i = 0; i <= n; i++)
            {
                while (s.Count > 0 && A[s.Peek()] < (i == n ? int.MaxValue : A[i])){
                    j = s.Pop();
                    k = s.Count == 0 ? -1 : s.Peek();
                    res += (long)A[j] * (i - j) * (j - k);
                }
                s.Push(i);
            }

            return res; 
        }

            public static int[] buildLeftBoundary(int[] ranks, int n)
        {
            int[] LBoundary = new int[n];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i =0; i<n; i++ )
            {
                LBoundary[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
                var rank = ranks[i];
                if (dict.ContainsKey(rank + 1))
                    LBoundary[i] = dict[rank + 1];
                dict[rank] = i;
            }
            return LBoundary;
        }
        public static int[] buildRightBoundary(int[] ranks, int n)
        {
            int[] RBoundary = new int[n];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                RBoundary[i] = n;
            }
            for (int i = n - 1; i >= 0; i--)
            {
                var rank = ranks[i];
                if (dict.ContainsKey(rank + 1))
                    RBoundary[i] = dict[rank + 1];
                dict[rank] = i;
            }
            return RBoundary;
        }
        public static int[] buildLeftNGE(int[] ranks, int n)
        {
            int[] LeftNGE = new int[n];
            for (int i = 0; i < n; i++)
            {
                LeftNGE[i] = -1;
            }
            List<int> stack = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var rank = ranks[i];
                while (stack.Count > 0 && rank > ranks[stack[stack.Count - 1]])
                    stack.RemoveAt(stack.Count - 1);
                if (stack.Count > 0)
                    LeftNGE[i] = stack[stack.Count - 1];
                stack.Add(i);
            }
            return LeftNGE;
        }
        public static int[] buildRightNGE(int[] ranks, int n)
        {
            int[] RightNGE = new int[n];
            for (int i = 0; i < n; i++)
            {
                RightNGE[i] = n;
            }
            List<int> stack = new List<int>();
            for (int i = n - 1; i >= 0; i--)
            {
                var rank = ranks[i];
                while (stack.Count > 0 && rank > ranks[stack[stack.Count - 1]])
                    stack.RemoveAt(stack.Count - 1);
                if (stack.Count > 0)
                    RightNGE[i] = stack[stack.Count - 1];
                stack.Add(i);
            }
            return RightNGE;
        }
        public static int studentRanks(int[] ranks)
        {
            int n = ranks.Length;
            var LBoundary = buildLeftBoundary(ranks, n);
            var RBoundary = buildRightBoundary(ranks, n);
            var NGELeft = buildLeftNGE(ranks, n);
            var NGERight = buildRightNGE(ranks, n);
            // printData(LBoundary, RBoundary, NGELeft, NGERight);

            var result = 0;
            for (int i = 0; i < n; i++)
            {
                var countOfStart = i - LBoundary[i];
                var countOfEnd = RBoundary[i] - i;
                var totalPossible = countOfStart * countOfEnd;
                var smallerSubCount = (i - NGELeft[i]) * (NGERight[i] - i);
                result += (totalPossible - smallerSubCount);
            }
            return result;
        }

        //private static ArrayList<String> scatterPalindrome(String param)
        //{
        //    int n = param.length();
        //    HashSet<String> res = new HashSet<>();
        //    if (param == null || n == 0)
        //    {
        //        return new ArrayList<String>();
        //    }

        //    HashMap<Character, Integer> charMap = new HashMap<>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        int numEven = 0;
        //        int numOdd = 0;
        //        charMap.clear();
        //        for (int j = i + 1; j < n + 1; j++)
        //        {
        //            System.out.println(i + "|" + j);
        //            char cur = param.charAt(j - 1);
        //            charMap.put(cur, charMap.getOrDefault(cur, 0) + 1);
        //            int curCount = charMap.get(cur);
        //            if (curCount % 2 == 0)
        //            {
        //                numEven++;
        //                numOdd--;
        //            }
        //            else
        //            {
        //                numOdd++;
        //                if (numEven > 0 && curCount != 1)
        //                {
        //                    numEven--;
        //                }
        //            }
        //            System.out.println(param.substring(i, j) + "|odd: " + numOdd + "|even: " + numEven);
        //            if (numEven == charMap.size() || numOdd == 1)
        //            {
        //                res.add(param.substring(i, j));
        //                System.out.println(param.substring(i, j) + " added to result");
        //            }
        //        }
        //    }
        //    return new ArrayList<String>(res);
        //} 
        //public static int scatterPalindrome(string s)
        //{
        //    int answer = 0;
        //    Dictionary<int, int> m = new Dictionary<int, int>();
        //    m[0] = 1;
        //    int x = 0; 
        //    foreach(var c in s)
        //    {
        //        int d = c - 'a';
        //        x ^= 1 << d;
        //        answer += m.GetValueOrDefault(x);
        //        for(int i =0; i<26; i++)
        //        {
        //            answer += m.GetValueOrDefault(x ^ (1<<i));
        //        }
        //        m[x] = m.GetValueOrDefault(x)+ 1;
  
        //    }
        //    return answer;

        //}

        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<string> list = new HashSet<string>();
                for (int j = 0; j < 9; j++)
                {
                    var curr = board[i][j];
                    if (curr != '.')
                    {
                        if (!list.Add(curr + "found in row" + i) || !list.Add(curr + "found in column" + j) || !list.Add(curr + "found in box" + i / 3 + "-" + j / 3))
                            return false;
                    }

                }
            }

            return true;
        }
        public static List<int> getEncryptedNumber(List<int> num)
        {
            while (num.Count > 2)
            {
                var temp = new List<int>();
                for (int i = 0; i < num.Count-1; i++)
                {
                    var val = num[i] + num[i + 1];
                    temp.Add(val % 10);
                }
                num.Clear();
                num.AddRange(temp);
                temp.Clear();
            }
            return num;
        }
        //{
        //    string n = Console.ReadLine();
        //    long a = Convert.ToInt64(n.Split(' ')[0]);
        //    long b = Convert.ToInt64(n.Split(' ')[1]);
        //    fibonaccii f = new fibonaccii();
        //    Console.WriteLine(f.gcd_fast(a,b));


        //    Console.WriteLine(f.squareFibLastDigitSum(1234567890));
        //    Console.WriteLine(f.partialFibLastDigitSum(10,200));
        //    Console.WriteLine(f.fibLastDigitSum(10000000));
        //    Console.WriteLine(f.fibonacciModulo(15482763,23));
        //    Console.WriteLine(f.lcm_fast(761457, 614573));
        //    Console.WriteLine(f.gcd_fast(5,3));
        //    Console.WriteLine(f.get_fibonacci_last_digit(40));
        //    //f.test_solution();
        //    Console.WriteLine(f.fibonacci_fast(40));
        //    int[] Arr = { 12, 34, 45, 9, 8, 90, 3 };
        //    OddEvenArray o = new OddEvenArray();
        //    int count = o.RemoveEven(ref Arr);
        //    o.SegregateArray(Arr);
        //}
    }
    
}



//private static double getMaxValue(int[] wt, int[] val,
//                                      int capacity)
//{
//    ItemValue[] iVal = new ItemValue[wt.length];

//    for (int i = 0; i < wt.length; i++)
//    {
//        iVal[i] = new ItemValue(wt[i], val[i], i);
//    }



//    double totalValue = 0d;

//    for (ItemValue i : iVal) {

//    int curWt = (int)i.wt;
//    int curVal = (int)i.val;

//    if (capacity - curWt >= 0)
//    {
//        // this weight can be picked while 
//        capacity = capacity - curWt;
//        totalValue += curVal;
//    }
//    else
//    {
//        // item cant be picked whole 
//        double fraction = ((double)capacity / (double)curWt);
//        totalValue += (curVal * fraction);
//        capacity = (int)(capacity - (curWt * fraction));
//        break;
//    }
//}

//return totalValue; 
//    } 


// static void stressTest(int n, int c)
//{
//    bool Truth = true;
//    while (Truth)
//    {
//        Random rand = new Random();
//        double n = (double)(100 * rand.Next(2, N));
//        double[] ar = new double[n];
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


