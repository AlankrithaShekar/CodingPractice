using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice
{
    public class LFUCache
    {
        Dictionary<int, int> keyvalue = new Dictionary<int, int>();
        LinkedList<int> linkedlist = new LinkedList<int>();
        Dictionary<int, LinkedListNode<int>> keynode = new Dictionary<int, LinkedListNode<int>>();
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int capacity;
        public LFUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!keyvalue.ContainsKey(key))
                return -1;
            freq[key]++;
            var value = keyvalue[key];
            var node = keynode[key];
            linkedlist.Remove(node);
            linkedlist.AddLast(node);
            return value;

        }

        public void Put(int key, int value)
        {
            if (!keyvalue.ContainsKey(key))
            {
                if (linkedlist.Count == capacity)
                {
                   
                    int min = freq.OrderBy(x => x.Value).FirstOrDefault().Key;
                    freq.Remove(min);
                    var node = keynode[min];
                    linkedlist.Remove(node);
                    keyvalue.Remove(min);

                }
                linkedlist.AddLast(key);
                keyvalue[key] = value;
                keynode[key] = linkedlist.Last;
                freq[key] = 0;
            }
            else
            {
                freq[key]++;
                keyvalue[key] = value;
                var node = keynode[key];
                linkedlist.Remove(node);
                linkedlist.AddLast(node);
            }
        }
    }

    public class LRUCache
    {
        Dictionary<int, int> list = new Dictionary<int, int>();
        LinkedList<int> linkedlist = new LinkedList<int>();
     
        int capacity;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!linkedlist.Contains(key))
                return -1;
            else
            {

                var val = list[key];
                linkedlist.Remove(key);
                linkedlist.AddLast(key);
                return val;
            }
        }

        public void Put(int key, int value)
        {
            if (!list.ContainsKey(key) || !linkedlist.Contains(key))
            {
                if (linkedlist.Count != capacity)
                {
                    list[key] = value;
                    linkedlist.AddLast(key);
                }
                else
                {
                    list.Remove(linkedlist.First());
                    linkedlist.RemoveFirst();
                    list[key] = value;
                    linkedlist.AddLast(key);
                }
            }
            else
            {
                list[key] = value;
                linkedlist.Remove(key);
                linkedlist.AddLast(key);
            }

        }
    }
    public class HashMap<TKey, TValue>
    {
        public class HMNode
        {
            public TKey key;
            public TValue value; 

            public HMNode(TKey key, TValue value)
            {
                this.key = key; 
                this.value = value;
            }
        }

        private LinkedList<HMNode>[] buckets;
        private int size = 0; 

        public HashMap()
        {
            InitBuckets(4);
           
        }
        public void InitBuckets(int size)
        {
            buckets = new LinkedList<HMNode>[size];
            for(int i=0; i<buckets.Length; i++)
            {
                buckets[i] = new LinkedList<HMNode>();
            }
        }

        public int GetMyHashCode(TKey key)
        {
            var index = key.GetHashCode();
            return Math.Abs(index) % buckets.Length;

        }
        public int GetIndexWithinBucket(TKey key, int bucketIndex)
        {
            int di = 0;
            //if (buckets[bucketIndex] == null)
            //    return -1;
            foreach(var k in buckets[bucketIndex])
            {
                if(k.key.Equals(key))
                {
                    return di;
                }
                di++;
            }
            return -1;
        }
        public void Put(TKey key, TValue value)
        {
            int bucketIndex = GetMyHashCode(key);
            int dataindex = GetIndexWithinBucket(key, bucketIndex);

            if(dataindex == -1)
            {
                buckets[bucketIndex].AddLast( new HMNode(key, value));
                size++;
            }
            else
            {
                HMNode node = buckets[bucketIndex].ElementAt(dataindex);
                node.value = value;
            }

            double lambda = size*1.0 / buckets.Length;
            if(lambda > 2)
            {
                ReHash();
                size = 0;
            }
        }

        public void ReHash()
        {
            var oldBucket = buckets;
            var N = oldBucket.Length * 2;
            InitBuckets(N);

            for(int i =0; i<oldBucket.Length; i++)
            {
                foreach(var node in oldBucket[i])
                {
                    Put(node.key, node.value);
                }
            }
        }

        public bool ContainsKey(TKey key)
        {
            int bucketIndex = GetMyHashCode(key);
            int dataindex = GetIndexWithinBucket(key, bucketIndex);

            if (dataindex == -1)
            {
                return false;
            }
            else
            {
                return true ;
            }
            
        }

        public TValue Get(TKey key)
        {
            int bucketIndex = GetMyHashCode(key);
            int dataindex = GetIndexWithinBucket(key, bucketIndex);

            if (dataindex == -1)
            {
                HMNode node = buckets[bucketIndex].ElementAt(dataindex);
                return node.value;
            }
            else
            {
                throw new KeyNotFoundException($"The given key '{key.ToString()}' was not present in the Hash-table.");
            }
        }

        public TValue Remove(TKey key)
        {
            int bucketIndex = GetMyHashCode(key);
            int dataindex = GetIndexWithinBucket(key, bucketIndex);

            if (dataindex != -1)
            {
                HMNode node = buckets[bucketIndex].ElementAt(dataindex);
                buckets[bucketIndex].Remove(node);
                return node.value;
            }
            else
            {
                throw new KeyNotFoundException($"The given key '{key.ToString()}' was not present in the Hash-table.");
            }
        }

        public List<TKey> KeySet()
        {
            List<TKey> list = new List<TKey>();
            for(int i=0; i<buckets.Length; i++)
            {
                foreach(var node in buckets[i])
                {
                    list.Add(node.key);
                }
            }
            
            
            
            return list;
        }
       
    }
}
