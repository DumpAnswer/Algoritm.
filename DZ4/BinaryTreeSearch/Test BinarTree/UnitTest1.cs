using NUnit.Framework;
using BinaryTreeSearch;
using Test_BinarTree;

namespace Test_BinarTree
{
    public class Tests
    {
        TreeList tree;
        
        [SetUp]
        public void Setup()
        {
            tree = new TreeList();
        }

        [Test]
        public void AddItem_Test1() // тест на добавление в пустой список

        {
            tree.AddItem(33);


            int actual = tree._root.Value;
            int expected = 33;

            Assert.AreEqual(expected, actual);
        }
        public void AddItem_Test2() //тест на добавлнеи правого и левого элемента
        {
            tree.AddItem(40);
            tree.AddItem(20);

            int actual1 = tree._root.RightChild.Value;
            int actual2 = tree._root.LeftChild.Value;

            int expected1 = 40;
        } 
    }
}