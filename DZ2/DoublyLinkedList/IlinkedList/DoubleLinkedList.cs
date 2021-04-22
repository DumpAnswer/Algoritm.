using System;
using System.Collections.Generic;
using System.Linq;
using static IlinkedList.Node;


namespace IlinkedList
{
    public class LinkedList : ILinkedList
    {
         Node _startNode { get; set; }
         Node _endNode { get; set; }
         int _count { get; set; }
        public void AddNode(int value)
        {
            var node = new Node { Value = value };
            if( _startNode == null )
            {
                _startNode = node;
            }
            else
            {
                _endNode.NextNode = node;
                node.PrevNode = _endNode;   
            }
            _endNode = node;
            _count++;
            
        }
        public void PrintList()
        {
            var node = _startNode;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.NextNode;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node == null)
            {
                return;
            }
            var newNode = new Node { Value = value };
            if(node == _endNode)
            {
                _endNode = newNode;
            }
            var nextItem = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextItem;
            newNode.PrevNode = node;
            _count++;
            
        }

        public Node FindNode(int searchValue)
        {
            var findNode = _startNode;
            while (findNode != null)
            {
                if(findNode.Value == searchValue)
                {
                    return findNode;
                }
                findNode = findNode.NextNode;
   
            }
            return null;
        }

        public int GetCount()
        {
            Console.WriteLine(_count);
            return _count;
        }

        public void RemoveNode(int index)
        {
            if (_count == 1)
            {
                _startNode = null;
                _endNode = null;
                _count--;
                return;
            }

            int current = 0;
            var delNode = _startNode;
            while(delNode != null)
            {
                if(current == index)
                {
                    RemoveNode(delNode);
                }
                delNode = delNode.NextNode;
                current++;
            }
            
        }

        public void RemoveNode(Node node)
        {
            var delNode = node;
            while (delNode != null)
            {
                if (delNode == node)
                {
                    
                    if (delNode == _startNode)
                    {
                        _startNode = _startNode.NextNode;
                        _startNode.PrevNode = null;

                        _count--;
                        return;
                    }
                    if(delNode == _endNode)
                    {
                        _endNode = _endNode.PrevNode;
                        _endNode.NextNode = null; 
                        
                        _count--;
                        return;
                    }
                    if(delNode == null)
                    {
                        return;
                    }

                    delNode.PrevNode.NextNode = delNode.NextNode;
                    delNode.NextNode.PrevNode = delNode.PrevNode;
                    _count--;
                    return;
                }
                delNode = delNode.NextNode;
            }
        }
    }
}