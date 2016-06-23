using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsConsole;

namespace TreeTests
{
    [TestClass]
    public class TreeStructureTests
    {
        Node _tree;

        [TestInitialize]
        public void Init()
        {
            _tree = new Node(1);
            _tree.AddNode(3);
            _tree.AddChildNode(2).AddNode(4).AddNode(5);
            _tree.AddNode(7).AddChildNode(10);
        }

        [TestMethod]
        public void FindMaxinumElementTest()
        {
            SimpleTreeTasks t = new SimpleTreeTasks();
            int maxValue = t.FindMaxWithoutRecursion(_tree);
            Assert.IsTrue(maxValue == 10);
        }
    }
}
