using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedListDS
{
    internal class OrderedListClass
    {
        Node head = null;
        public int[] insertArray = new int[10];
        public int position = 0;

        public int InsertPosition(int newNodeData)
        {
            if (position == 0)
            {
                insertArray[position] = newNodeData;
                return position;
            }
            while (newNodeData < insertArray[position])
            {
                position++;
            }
            insertArray[position] = newNodeData;
            return position;
        }        
        public int Insert(int newNodeData)
        {

            Node newNode = new Node(newNodeData);
            Node temp = null, next = null, prevNode = null;
            int pos = InsertPosition(newNodeData);
            if (pos == 0)
            {
                temp = this.head;
                newNode.next = this.head;
                this.head = newNode;
                position++;
                return pos;

            }
            else if (pos > 0)
            {
                prevNode = this.head;
                while (pos != 0)
                {
                    if (pos == 1)
                    {                        
                        newNode.next = prevNode.next;
                        prevNode.next = newNode;
                        return pos;
                        break;
                    }
                    prevNode = prevNode.next;
                    pos--;
                }
                if (position != 1)
                {
                    Console.WriteLine("Invalid Postion");
                    return pos;
                }
                return pos;
            }
            else
            {
                Console.WriteLine("Invalid Postion");
                return pos;
            }
        }
        public void Sort()
        {
            if (this.head == null)
            {
                return;
            }
            var temp = this.head;
            Node hold = null;
            this.head = null;            
            while (temp != null)
            {
                hold = temp;
                temp = temp.next;
                hold.next = null;                
                if (this.head == null)
                {
                    this.head = hold;
                }
                else if (this.head.data >= hold.data)
                {
                    hold.next = this.head;
                    this.head = hold;
                }
                else
                {
                    var temp1 = this.head;                    
                    while (temp1.next != null &&
                           temp1.next.data < hold.data)
                    {

                        temp1 = temp1.next;
                    }
                    hold.next = temp1.next;
                    temp1.next = hold;
                }
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
            }
            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void Remove(int find)
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
