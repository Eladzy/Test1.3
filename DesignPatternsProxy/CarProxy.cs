using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProxy
{
    class CarProxy : ICarService
    {
        public CarProxy()
        {

        }
        public void ShowGasState()
        {
            ICarService carService = new CarSys();
            carService.ShowGasState();
        }

        public void ShowLocation()
        {
            ICarService carService = new CarSys();
            carService.ShowLocation();
        }
    }
}
