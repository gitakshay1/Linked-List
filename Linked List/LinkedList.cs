using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class LinkedList
    {
        Node Head;
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if(Head==null)
            {
                Head = node;
            }
            else
            {
                Node temp = Head;
                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(node.data + " is added to linked-list");
        }
        public void DisplayLinkedList()
        {
            Console.WriteLine("Linked List");
            Node tempnode = Head;
            while (tempnode != null)
            {
                Console.WriteLine(tempnode.data);
                tempnode = tempnode.Next;
            }
        }
    }
}
