using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice
{
    public class TrieNode
    {
        public bool isWord;
        public Dictionary<char, TrieNode> children;

        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }
    }

    public class Trie
    {
        readonly TrieNode root;

        public Trie()
        {
            this.root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode curr = root;
            foreach (char c in word)
            {
                if (!curr.children.ContainsKey(c))
                {
                    curr.children.Add(c, new TrieNode());
                }
                curr = curr.children[c];
            }
            curr.isWord = true;
        }

        public bool Search(string word)
        {
            TrieNode curr = root;
            foreach (char c in word)
            {
                if (!curr.children.ContainsKey(c))
                    return false;
                curr = curr.children[c];
            }
            return true;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode curr = root;
            foreach (char c in prefix)
            {
                if (!curr.children.ContainsKey(c))
                    return false;
                curr = curr.children[c];
            }
            return true;
        }

        public string Commonprefix()
        {
            TrieNode curr = root;
            string commonprefix = "";
            while (curr != null)
            {
                char x;
                if (curr.children.Count == 1)
                {
                    x = curr.children.Keys.First();
                    commonprefix += x;
                }
                else
                    return commonprefix;
                curr = curr.children.GetValueOrDefault(x);
            }
            return commonprefix;
        }
    }

    //public class TrieNode 
    //{
    //    public Dictionary<char, TrieNode> Children;
    //    public TrieNode()
    //    {
    //        Children = new Dictionary<char, TrieNode>();
    //    }
    //}

    //public class Trie
    //{
    //    readonly TrieNode root; 

    //    public Trie()
    //    {
    //        this.root = new TrieNode();
    //    }
    //    public void Insert(string word)
    //    {
    //        TrieNode curr = root;
    //        foreach(var c in word)
    //        {
    //            if (!curr.Children.ContainsKey(c))
    //                curr.Children.Add(c, new TrieNode());
    //            curr = curr.Children[c];
    //        }
    //        curr.Children.Add('*', new TrieNode());
    //    }

    //    public bool StartsWith(string prefix)
    //    {
    //        TrieNode curr = root;
    //        foreach (var c in prefix)
    //        {
    //            if (!curr.Children.ContainsKey(c))
    //                return false;
    //            curr = curr.Children[c];
    //        }
    //        return true; 
    //    }

    //    public bool Search(string word)
    //    {
    //        return StartsWith(word + '*');
    //    }

    //    public string LongestCommonPrefix(string[] strs)
    //    {
    //        var result = new StringBuilder();
    //        var firstWord = strs[0];
    //        for (int j =0; j< firstWord.Length; j++)
    //        {
    //            for (int i = 1; i < strs.Length ; i++)
    //            {
    //                var curr = strs[i];
    //                if (j >= strs[i].Length || firstWord[j] != curr[j])
    //                    return result.ToString();
    //            }
    //            result.Append(firstWord[j]);
    //        }
    //        return result.ToString();
    //    }
    //    public string Commonprefix()
    //    {
    //        TrieNode curr = root;
    //        string commonprefix = "";
    //        while (curr != null)
    //        {
    //            char x; 
    //            if (curr.Children.Count == 1)
    //            {
    //                x = curr.Children.Keys.First();
    //                commonprefix += x;
    //            }
    //            else
    //                return commonprefix;
    //            curr = curr.Children.GetValueOrDefault(x) ; 
    //        }
    //        return commonprefix;
    //    }

    //    public int majorityElement(int[] nums)
    //    {
    //        return majorityElementRec(nums, 0, nums.Length - 1);
    //    }
    //    private int majorityElementRec(int[] nums, int lo, int hi)
    //    {
    //        // base case; the only element in an array of size 1 is the majority
    //        // element.
    //        if (lo == hi)
    //        {
    //            return nums[lo];
    //        }

    //        // recurse on left and right halves of this slice.
    //        int mid = (hi - lo) / 2 + lo;
    //        int left = majorityElementRec(nums, lo, mid);
    //        int right = majorityElementRec(nums, mid + 1, hi);

    //        // if the two halves agree on the majority element, return it.
    //        if (left == right)
    //        {
    //            return left;
    //        }

    //        // otherwise, count each element and return the "winner".
    //        int leftCount = countInRange(nums, left, lo, hi);
    //        int rightCount = countInRange(nums, right, lo, hi);

    //        return leftCount > rightCount ? left : right;
    //    }
    //    private int countInRange(int[] nums, int num, int lo, int hi)
    //    {
    //        int count = 0;
    //        for (int i = lo; i <= hi; i++)
    //        {
    //            if (nums[i] == num)
    //            {
    //                count++;
    //            }
    //        }
    //        return count;
    //    }
    //}

}
