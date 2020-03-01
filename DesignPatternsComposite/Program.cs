using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsComposite
{
    class Program
    {
        static void Main(string[] args)
        {

            //comment out the uneven leaves to get true result on IsEven
            Component root = new Composite("root", 2);
            Component container1 =new Composite("container1", 10);
            Component container2= new Composite("container2", 30);
           
            Component leaf1 = new Leaf("leaf1",12);
            Component leaf2 = new Leaf("leaf21", 34);
            Component leaf3 = new Leaf("leaf2", 8);
            Component leaf4 = new Leaf("leaf3", 6);
            Component leaf5 = new Leaf("leaf3", 5); //uneven

            root.AddChild(container1);
            root.AddChild(container2);
            container1.AddChild(leaf1);
            container1.AddChild(leaf2);
            container2.AddChild(leaf3);
            container2.AddChild(leaf4);
            container2.AddChild(leaf1);
            container2.AddChild(leaf5);//uneven
            root.Sum();
            Console.WriteLine("root sum");
            container1.Sum();
            Console.WriteLine("container1 sum");
            container2.Sum();
            Console.WriteLine("container2 sum");
            Console.WriteLine(root.IsEven());
            Console.ReadLine();
        }
    }
}
