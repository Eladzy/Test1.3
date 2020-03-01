using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsComposite
{
    public abstract class Component
    {
        protected string Name;

        public abstract int Value { get; set; }

        public Component(string name,int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public abstract void AddChild(Component c);


        public abstract void RemoveChild(Component c);


        public abstract IList<Component> GetChilds();

        public abstract int Sum();
        public abstract bool IsEven();

        public string GetName()
        {
            return this.Name;
        }

    }
}
