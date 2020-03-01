using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkingQuestionNum2
{
    public class ValueContainer
    {
        public double? value { get; set; }
       public int amount { get; set; }

    }


    public class StackClass
    {
        private Stack MyStack=new Stack();

        private  ValueContainer MinValue = new ValueContainer
        {
            value = null,
            amount = 0
        };
        
        private static ValueContainer MaxValue = new ValueContainer
        {
            value = null,
            amount = 0
        };
        public StackClass()
        {
            
        }
        public  void Push(object obj)
        {
            MyStack.Push(obj);
            if (obj != null)
            {
                double numObj;
                if (double.TryParse(obj.ToString(),out numObj))
                {
                    
                    if (MinValue.value ==numObj)
                        MinValue.amount++;
                    if (MaxValue.value == numObj)
                        MaxValue.amount++;
                    if (MinValue.value == null || MinValue.value>= numObj)
                    {
                        MinValue.value = numObj;
                        MinValue.amount = 1;
                    }
                    if (MaxValue.value == null || MaxValue.value < numObj)
                    {
                        MaxValue.value = numObj;
                        MaxValue.amount = 1;
                    }
                }
            }
        }
        public  object Pop()
        {
            var tempObj = MyStack.Pop().ToString();
            double tempDouble;
            if (double.TryParse(tempObj,out tempDouble))
            {
               
                if (tempDouble == MaxValue.value)
                {
                    MaxValue.amount--;
                    MaxValue.value = MaxValue.amount > 0 ? MaxValue.value : null;
                }
                if (tempDouble == MinValue.value)
                {
                    MinValue.amount--;
                    MinValue.value = MinValue.amount > 0 ? MinValue.value : null;
                }
            }
            return tempObj;
        }

        public  object Peek()
        {
            return MyStack.Peek();
            
        }

        public void GetMax()
        {
            if (MaxValue.value == null)
            {
                Console.WriteLine("No Numbers in stack");
            }
            else
            {
                Console.WriteLine("max is " + MaxValue.value);
            }

        }

        public void GetMin()
        {
            if (MinValue.value == null)
            {
                Console.WriteLine("No Numbersin stack");
            }
            else
            {
                Console.WriteLine("min is " + MinValue.value);
            }
        }
    }
}
