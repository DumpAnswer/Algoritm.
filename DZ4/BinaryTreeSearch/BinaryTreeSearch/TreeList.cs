using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSearch
{
   



    public class TreeList : ITree
    {
       public TreeNode _root { get; set; }

        public void AddItem(int value)
        {
            var treeNode = new TreeNode() { Value = value };
            TreeNode tmp = _root;
            if (_root == null)
            {
                _root = treeNode;
                treeNode.Parent = null;
                return;
            }

            while (tmp != null)
            {
                if (tmp.Value <= treeNode.Value)
                {
                    if (tmp.RightChild != null)
                    {
                        tmp = tmp.RightChild;
                        continue;
                    }
                    else
                    {
                        treeNode.Parent = tmp;
                        tmp.RightChild = treeNode;
                        return;
                        
                    }
                }
                else if (tmp.Value > treeNode.Value)
                {
                    if(tmp.LeftChild != null)
                    {
                        tmp = tmp.LeftChild;
                        continue;
                    }
                    else
                    {
                        treeNode.Parent = tmp;
                        tmp.LeftChild = treeNode;

                        return;
                    }
                }
            }


        }

        public TreeNode GetNodeByValue(int value)
        {
            var findTree = new TreeNode() { Value = value };
            TreeNode result = null;
            TreeNode tmp = _root;

            if(_root == null)
            {
                return null;
            }

            while (tmp != null)
            {
                if(tmp.Value <= findTree.Value)
                {
                    if(tmp.Value != findTree.Value)
                    {
                        tmp = tmp.RightChild;
                        
                    }
                    else 
                    {
                        
                        result = tmp;
                        tmp = tmp.RightChild;
                    }
                }
                else if(tmp.Value > findTree.Value)
                {
                    if(tmp.Value != findTree.Value)
                    {
                        tmp = tmp.LeftChild;
                        
                    }
                    else
                    {
                        
                        result = tmp;
                        tmp = tmp.LeftChild;
                    }
                }
                
            }

            return result;
        }

        public TreeNode GetRoot()
        {
            
            return _root;
        }

        public void PrintTree()
        {
            Print(_root, 3);
            
        }
        public void Print(TreeNode p, int padding)
        {
            if(p != null)
            {
                if(p.RightChild != null)
                {
                    Print(p.RightChild, padding + 2);
                }
                if(padding > 0)
                {
                    Console.Write("".PadLeft(padding));
                }
                if(p.RightChild != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Value.ToString() + "\n ");
                if (p.LeftChild != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.LeftChild, padding + 2);
                }
            }
        }

        public void RemoveItem(int value)
        {

            
            TreeNode delTree = GetNodeByValue(value); //значение на удаление
            TreeNode curTree = delTree.Parent; //ссылка на Parent найденого значения
            TreeNode tmp = _root; 
            if (delTree == null)  // проверка на пустое значение 
            {
                return;
            }
            if(delTree == _root) // если удаляется корень
            {
                tmp = tmp.LeftChild;
               while(tmp.RightChild != null)
                {
                    tmp = tmp.RightChild;
                }
               if(tmp.LeftChild != null)
                {
                    tmp.Parent.RightChild = tmp.LeftChild;
                    tmp.LeftChild.Parent = tmp.Parent;
                }
                _root = tmp;
                tmp.Parent = null;
                tmp.LeftChild = delTree.LeftChild;
                delTree.LeftChild.Parent = tmp;
                tmp.RightChild = delTree.RightChild;
                delTree.RightChild.Parent = tmp;
                return;
            }

            if (curTree.RightChild == delTree) //проверка правой части 
            {
                if(delTree.RightChild != null && delTree.LeftChild != null)
                {
                    curTree.RightChild = null;
                    curTree.RightChild = delTree.RightChild;
                    delTree.RightChild.Parent = curTree;
                    delTree.LeftChild.Parent = delTree.RightChild;
                    delTree.RightChild.LeftChild = delTree.LeftChild;
                    return;
                    
                }
                if (delTree.RightChild == null && delTree.LeftChild != null)
                {
                    curTree.RightChild = null;
                    curTree.RightChild = delTree.LeftChild;
                    delTree.LeftChild.Parent = curTree;

                    return;
                }

                if (delTree.RightChild != null && delTree.LeftChild == null)
                {
                    curTree.RightChild = null;
                    curTree.RightChild = delTree.RightChild;
                    delTree.RightChild.Parent = curTree;
                }

                if (delTree.RightChild == null && delTree.LeftChild == null)
                {
                    curTree.RightChild = null;

                    return;

                }
            }
            if (curTree.LeftChild == delTree) // проверка левой части 
            {
                if(delTree.LeftChild != null && delTree.RightChild != null)
                {
                    curTree.LeftChild = null;
                    curTree.LeftChild = delTree.RightChild;
                    delTree.RightChild.Parent = curTree;
                    delTree.LeftChild.Parent = delTree.RightChild;
                    delTree.RightChild.LeftChild = delTree.LeftChild;
                    return;
                }

                if (delTree.RightChild == null && delTree.LeftChild != null)
                {
                    curTree.RightChild = null;
                    curTree.RightChild = delTree.LeftChild;
                    delTree.LeftChild.Parent = curTree;

                    return;
                }

                if (delTree.RightChild != null && delTree.LeftChild == null)
                {
                    curTree.RightChild = null;
                    curTree.RightChild = delTree.RightChild;
                    delTree.RightChild.Parent = curTree;
                    return;
                }
                if (delTree.RightChild == null && delTree.LeftChild == null)
                {
                    curTree.LeftChild = null;

                    return;

                }
            }

           

        }
    }
}
