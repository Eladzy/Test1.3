using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProxy
{
    class CarSys : ICarSys,ICarService
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void EndDrive()
        {
            throw new NotImplementedException();
        }

        public void ShowGasState()
        {
            Console.WriteLine("Mucho mucho gas!!");
        }

        public void ShowLocation()
        {
            Console.WriteLine("Right Over There!");
        }

        public void StartCar()
        {

        }

        public void TurnLeft()
        {
            throw new NotImplementedException();
        }

        public void TurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
