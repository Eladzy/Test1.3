using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsComposite
{
    class Leaf : Component
    {
     

        public override int Value { get; set; }       

        public Leaf(string name, int value) : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override void AddChild(Component c)
        {
            throw new NotImplementedException();
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotImplementedException();
        }

        public override int Sum()
        {
            return this.Value;
        }

        public override bool IsEven()
        {
            return this.Value % 2 == 0;
        }
    }
}
