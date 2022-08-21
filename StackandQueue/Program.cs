using System;
using System.Collections;

namespace StackandQueue
{
    public class program
    {

        public static void Main(string[] args)
        {
            
            Queue_Ex queueobj=new Queue_Ex();
            queueobj.Enqueue(10);
            queueobj.Enqueue(20);
            queueobj.Enqueue(30);
            queueobj.Display();
        }
    }



}
