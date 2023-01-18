using System.Collections.Generic;
using System.Xml.Linq;

namespace Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList= new LinkedList();
            //linkedList.AddNode(56);
            //linkedList.AddNode(30);
            //linkedList.AddNode(70);
            //linkedList.DisplayLinkedList();

            //linkedList.AddReverse(70);
            //linkedList.AddReverse(30);
            //linkedList.AddReverse(56);
            //linkedList.DisplayLinkedList();

            linkedList.Appending(30);
            linkedList.Appending(70);
            linkedList.Appending(56);
            linkedList.DisplayLinkedList();

        }
    }
}