using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDecorator
{
    class HasColoredFrame:WindowAbillitiesBase
    {
        public HasColoredFrame(IWindow window) : base(window)
        {
            this.Window = window;
        }

        public override string ShowAbillities()
        {
            return this.Window.ShowAbillities() + " I have colored frame";
        }
    }
}
