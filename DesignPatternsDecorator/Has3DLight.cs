using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDecorator
{
    class Has3DLight : WindowAbillitiesBase
    {
        public Has3DLight(IWindow window) : base(window)
        {
            this.Window = window;
        }

        public override string ShowAbillities()
        {
            return this.Window.ShowAbillities() + " I have 3D lights";
        }
    }
}
