using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowBase window = new WindowBase();
            Console.WriteLine(window.ShowAbillities());
            CanFlicker flickerWindow = new CanFlicker(window);
            HasShading hasShading = new HasShading(flickerWindow);
            Console.WriteLine(hasShading.ShowAbillities());
            CanTransparant canTransparant = new CanTransparant(hasShading);
            Console.WriteLine(canTransparant.ShowAbillities());
        }
    }
}
