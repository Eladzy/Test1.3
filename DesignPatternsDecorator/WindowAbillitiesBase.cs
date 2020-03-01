using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDecorator
{
    public abstract class WindowAbillitiesBase : IWindow
    {
        protected IWindow Window;

        public abstract string ShowAbillities();

        public WindowAbillitiesBase(IWindow window)
        {
            this.Window = window;
        }
       
    }
}
