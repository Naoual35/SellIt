using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Cars
{
    public class CarShowAccessor
    {
        public Car Car { get; set; }

        public CarShowAccessor()
        {
            this.Car = new Car();
        }
    }
}
