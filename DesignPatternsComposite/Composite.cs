using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsComposite
{
    public class Composite : Component
    {
        private IList<Component> Childs = new List<Component>();

        public override int Value { get; set; }


        public Composite(string name, int value) : base(name, value)
        {

        }


        public override void AddChild(Component c)
        {
            Childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return Childs;
        }

        public override void RemoveChild(Component c)
        {
            Childs.Remove(c);
        }

        public override int Sum()
        {
            int sum = this.Value;
            if(this.GetChilds()!=null)
            { 
                 foreach(Component child in Childs)
                 {
                     sum += child.Sum();
                 }
            }    
            Console.WriteLine(sum);
            return sum;
        }

        public override bool IsEven()
        {
            if (this.Value % 2!= 0)
                return false;
            if (this.GetChilds() != null)
            {
                foreach (Component component in Childs)
                {
                    if (!component.IsEven())
                        return false;
                }
            }
            return true;
        }
    }
}
