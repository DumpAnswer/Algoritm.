using System;
using System.Collections.Generic;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeList tree = new TreeList();
            tree.AddItem(30);
            tree.AddItem(20);
            tree.AddItem(40);
            tree.AddItem(15);
            tree.AddItem(25);
            tree.AddItem(35);
            tree.AddItem(45);

            tree.DFS(15);
        }
    }
}
