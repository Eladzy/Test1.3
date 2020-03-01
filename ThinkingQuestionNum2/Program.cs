using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkingQuestionNum2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new StackClass();
            myStack.Push(5);
            myStack.Push(3);
            myStack.Push(2);
            myStack.GetMax();
            myStack.GetMin();
            myStack.Pop();
            myStack.Push(4);
            myStack.GetMin();
        }
    }
}
