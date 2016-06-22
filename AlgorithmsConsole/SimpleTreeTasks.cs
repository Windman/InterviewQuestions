using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    public class Node
    {
        public int Data;

        public List<Node> Child;

        public Node(int value)
        {
            Data = value;
            Child = new List<Node>();
        }

        public Node AddNode(int value)
        {
            Child.Add(new Node(value));
            return this;
        }

        public Node AddChildNode(int value)
        {
            var node = new Node(value);
            Child.Add(node);
            return node;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class SimpleTreeTasks
    {
        internal Node CreateTree()
        {
            var tree = new Node(1);
            tree.AddNode(3);
            tree.AddChildNode(2).AddNode(4).AddNode(5);
            tree.AddNode(7);
            return tree;
        }

        int max;

        internal int FindMaxRecursionSolution(Node tree)
        {
            if (max < tree.Data)
                max = tree.Data;

            foreach (var item in tree.Child)
            {
                FindMaxRecursionSolution(item);
            }

            return max;
        }

        public int FindMaxWithoutRecursion(Node tree)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(tree);
            max = tree.Data;

            while (q.Count > 0)
            {
                var n = q.Dequeue();
                if (max < n.Data)
                    max = n.Data;

                foreach (var item in n.Child)
                {
                    q.Enqueue(item);
                }
            }

            return max;
        }
    }
}
