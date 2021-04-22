using System;
using Xunit;
using IlinkedList;
using System.Collections;
using System.Collections.Generic;

namespace TestApp
{
    public class UnitTest1
    {
        LinkedList list = new LinkedList() ;

        
       
        // ���������� �������� � ������ ������ 
        [Fact]
        public void AddNote_Test()
        {
            
            list.AddNode(44);

            int actual = list._endNode.Value;
            int expect = 44;

            Assert.Equal(expect, actual);
          
        }
        // �������� �� ���������� ��������� � �����
        [Fact]
        public void Count_Test()
        {
            list.AddNode(1);
            list.AddNode(1);
            list.AddNode(1);
            list.AddNode(1);
            list.AddNode(1);
            int actual = list.GetCount();
            int expect = 5;

            Assert.Equal(expect, actual);
        }
        // ���������� ������ ����� ���������� ��������
        [Fact]
        public void AddAfter_FindTest()
        {
            list.AddNode(1);
            list.AddNode(2);
            list.AddNodeAfter(list.FindNode(2),74);
            list.AddNode(4);
            list.AddNode(5);
            int actual = list.FindNode(2).NextNode.Value;
            int expect = 74;

            Assert.Equal(expect, actual);
        }
        // �������� ���������� �������� �� �������
        [Fact]
        public void RemoveNodeIndex_Test()
        {
            list.AddNode(1);
            list.AddNode(59);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.RemoveNode(0);

            

            
            int actual = list._startNode.Value;
            int expect = 59;

            Assert.Equal(expect, actual);
        }
        // �������� ��������� �������� �� ����
        [Fact]
        public void RemoveNode_Test()
        {
            list.AddNode(1);
            list.AddNode(59);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.RemoveNode(list._startNode);




            int actual = list._startNode.Value;
            int expect = 59;

            Assert.Equal(expect, actual);
        }
      

    }

}
