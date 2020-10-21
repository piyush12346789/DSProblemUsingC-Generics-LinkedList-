using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList1
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        public void InsertAtGivenPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node n = head, previous = head, after;
                for (int pos = 1; pos < position; pos++)
                {
                    n = n.next;
                    if (pos == position - 2)
                    {
                        previous = n;
                    }
                }
                after = n;
                previous.next = node;
                node.next = after;
            }
        }
        public Node RemoveFirstElement()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty.");
            }
            else
            {
                head = head.next;
            }
            return this.head;
            
        }
        public Node RemoveLastElement()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty.");
                return null;
            }
            else
            {
                Node NewNode = head;
                while(NewNode.next.next != null)
                {
                    NewNode = NewNode.next;
                }
                Node removedNode = NewNode.next;
                NewNode.next = null;
                return removedNode;
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
    }
}  