using SellIt_UWP.Views.ViewModels.UCAccessors.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class CarPageAccessor
    {
        public CarEditAccessor CarEdit { get; set; }
        public CarListAccessor CarList { get; set; }
        public CarShowAccessor CarShow { get; set; }
        public CarDeleteAccessor CarDelete { get; set; }

        public CarPageAccessor()
        {
            this.CarEdit = new CarEditAccessor();
            this.CarList = new CarListAccessor();
            this.CarShow = new CarShowAccessor();
            this.CarDelete = new CarDeleteAccessor();
        }
    }
}
