using NUnit.Framework;
using BinaryTreeSearch;
using Test_BinarTree;

namespace Test_BinarTree
{
    public class Tests
    {
        TreeList tree;
        
        [SetUp]
        public void Setup() // Add Item
        {
            tree = new TreeList();
            tree.AddItem(33);
            tree.AddItem(20);
            tree.AddItem(25);
            tree.AddItem(15);
            tree.AddItem(40);
            tree.AddItem(35);
            tree.AddItem(45);

        }

        [Test]
        public void GetNodeItem_Test1() // Link search test 1

        {
            tree.GetNodeByValue(20);


            int actual = tree._root.LeftChild.Value;
            int expected = 20;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetNodeItem_Test2() // Link search test 2
        {
            tree.GetNodeByValue(40);
            

            int actual1 = tree._root.RightChild.Value;
            

            int expected1 = 40;
            

            Assert.AreEqual(expected1, actual1);
           
        } 
        [Test]
        public void RemoveItem_Test1() //Root removal Test
        {
            tree.RemoveItem(33);

            int actual = tree._root.Value;
            int expected = 25;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void RemoveItem_Test2()//Test for deleting a node that has a left and right child
        {
            tree.RemoveItem(20);

            int actual = tree._root.LeftChild.Value;
            int expected = 25;

            Assert.AreEqual(expected, actual);
        }
       
        [Test]
        public void RemoveItem_Testó3()// Test for deleting a node that has no descendants
        {
            tree.RemoveItem(25);

            var actual = tree._root.LeftChild.RightChild;
            string expected = null;

            Assert.AreEqual(expected, actual);
        }
    }
}