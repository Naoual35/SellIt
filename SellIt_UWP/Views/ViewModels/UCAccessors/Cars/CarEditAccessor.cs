using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Cars
{
    public class CarEditAccessor
    {
        public Car Car { get; set; }
        public ButtonAccessor Button { get; set; }
        public CarEditAccessor()
        {
            this.Car = new Car();
            this.Button = new ButtonAccessor();
        }
    }
}
