using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    public class SimpleTreeTasks
    {
        class Node
        {
            public int Data;
            
            private List<Node> Child;
            
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

            public Node AddToLastChildNode(int value)
            {
                Child.Add(new Node(value));
                return Child.Last();
            }
        }

        private Node tree;

        public void PopulateTreeStructure()
        {
            tree = new Node(1);
            tree.AddNode(3);
            tree.AddNode(2).AddNode(4);
            tree.AddNode(7);
        }

        public void Go()
        {
            PopulateTreeStructure();
        }

    }
}
