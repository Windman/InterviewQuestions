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
            tree.AddChildNode(2).AddNode(4).AddNode(5).AddChildNode(8).AddNode(10);
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
    }
}
