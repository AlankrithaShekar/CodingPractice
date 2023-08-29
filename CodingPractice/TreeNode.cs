using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice
{
 //Definition for a binary tree node.
 public class TreeNode
 {
      public int val;
      public TreeNode left;
      public TreeNode right;
      
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
            this.val = val;
            this.left = left;
            this.right = right;
      }
 }

    public class Tree
    {
        public  string serialize(TreeNode root, string sb)
        {
            if (root == null)
                sb+="NULL,";
            else
            {
                sb += (root.val.ToString()+ ",");
                sb = serialize(root.left,sb);
                sb = serialize(root.right,sb);
            }
            
            return sb;
        }

        public TreeNode deserialize(string data)
        {
            if (data == "NULL")
                return null;
            var nodes = data.Split(',');
            TreeNode root = new TreeNode(Convert.ToInt32(nodes[0]));
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[2 * i + 1] == "NULL" && nodes[2 * i + 2] == "NULL")
                    continue;
                root.left = new TreeNode(Convert.ToInt32(nodes[2 * i + 1]));
                root.right = new TreeNode(Convert.ToInt32(nodes[2 * i + 2]));
            }

            return root;
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            var cur = root;
            while (cur.left != null)
            {
                stack.Push(cur.left);
                cur = cur.left;
            }
            while (stack.Count > 0)
            {

                var temp = stack.Peek().right;
                if(temp == null)
                {
                    temp = stack.Pop();
                    list.Add(temp.val);
                    //while (stack.Count > 0 && temp == )
                    {
                        temp = stack.Pop();
                        list.Add(temp.val);
                    }
                }
                else
                {
                    cur = temp;
                }
                //Console.WriteLine(cur.val);
                //if (cur.right != null)
                //{
                //    stack.Push(cur.right);
                //    cur = cur.right;
                //}
                //else
                //{
                //    //Console.WriteLine(stack.Pop().val);
                //    list.Add(stack.Pop().val);
                //}
            }
            return list;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var size = q.Count;
                List<int> list = new List<int>();
                while (size > 0)
                {
                    var curr = q.Dequeue();
                    list.Add(curr.val);
                    if (curr.left != null)
                        q.Enqueue(curr.left);
                    if (curr.right != null)
                        q.Enqueue(curr.right);
                    size--;
                }
                result.Add(list);
            }

            return result;
        }
    }
}
