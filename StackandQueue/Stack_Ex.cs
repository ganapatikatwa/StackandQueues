using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class Stack_Ex
    {
        Node top;
        
        public Stack_Ex()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newnode=new Node(data);
            newnode.Next = top;
            top = newnode;

        }
        public void Display()
        {
            if(top==null)
            {
                Console.WriteLine("Stack id Empty");
            }
            Node temp = top;
            while(temp!=null)
            {
                Console.WriteLine(" "+temp.data+" ");
                temp = temp.Next;

            }
        }
        public void peek()
        {
            if(top==null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Node temp = top;
            Console.WriteLine(temp.data+"is top element");
        }

        public void pop()
        {
            if(top==null)
            {
                Console.WriteLine("Stack is Empty");
            }
            this.top = this.top.Next;

        }
    }
}
