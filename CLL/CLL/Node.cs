using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data) { this.data = data; }
        public Node() {  }
    }

    class CLL
    {
        Node last = null;

        public void append(int Data)
        {
            Node newnode = new Node();
            newnode.data = Data;
            if (last == null)
            {
                last = newnode;
                newnode.next = newnode;
            }
            newnode.next = last.next;
            last.next = newnode;
            last = newnode;
        }
        public void addfront(int Data)
        {
            Node newnode = new Node(Data);
            newnode.next = last.next;
            last.next = newnode;
        }

        public void print()
        {
            Node newnode = last.next;
            while (newnode != last)
            {
                Console.Write(newnode.data + " ");
                newnode = newnode.next;
            }
            Console.WriteLine(newnode.data);
            Console.WriteLine();
        }
    }
}
