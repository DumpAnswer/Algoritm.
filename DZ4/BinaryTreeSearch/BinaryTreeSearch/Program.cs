using System;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeList tree = new TreeList();
            tree.AddItem(33);
            tree.AddItem(40);
            tree.AddItem(20);
            tree.AddItem(15);
            tree.AddItem(17);
            tree.AddItem(50);
            tree.AddItem(60);

            tree.PrintTree();

        }
    }
}
