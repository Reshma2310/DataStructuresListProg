using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnOrderedListDS
{
    internal class UnOrderedClass
    {
        internal Node head;
        public void Add(string data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }            
        }
        public void Display()
        {
            Console.WriteLine("Displaying the words in list");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }        
        public void Remove(string find)
        {
            Node node = this.head, prevNode = null;
            while (node != null)
            {
                if (node.data == find)
                {
                    prevNode.next = (Node)node.next;
                    break;
                }
                prevNode = node;
                node = node.next;
            }
        }        
    }
}
