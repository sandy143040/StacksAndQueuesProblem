using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StacksAndQueuesProblem
{
    public class StackLinkedList
    {
        public Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is inserted into stack", newNode.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is inserted into stack", newNode.data);
            }
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = top;
                Console.WriteLine("Displaying Stack elements");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;

                }
            }
        }
    }
}
