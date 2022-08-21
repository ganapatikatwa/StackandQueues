using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class Queue_Ex
    {
        Node rear;
        Node front;

        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear = rear.Next;
            }
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine(" " + temp.data + " ");
                temp = temp.Next;
            }
        }
        
        public void Dequeue()
        {
            if (this.front==null)
            {
                Console.WriteLine("Queue is Empty,Deletion is not Possible");
                return;
            }
            Console.WriteLine("{0} is element Dequeue", this.front.data);
            this.front = this.front.Next;

        }
    }
}
