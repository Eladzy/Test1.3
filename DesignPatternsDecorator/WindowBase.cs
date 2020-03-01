using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDecorator
{
    public class WindowBase : IWindow
    {
        public string ShowAbillities()
        {
            return "I am a Window";
        }
    }
}
