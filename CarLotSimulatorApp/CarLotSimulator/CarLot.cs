using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal static class CarLot
    {
        public static int numberOfCars = 1;

        public static List<Car> Cars { get; set;  } = new List<Car>();

        static CarLot() 
        {
                   
        }        
    }
}
