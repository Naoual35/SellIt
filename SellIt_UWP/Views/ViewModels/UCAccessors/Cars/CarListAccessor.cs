using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Cars
{
    public class CarListAccessor
    {
        public ObservableCollection<Car> Cars { get; set; }
        public ListViewAccessor<Car> ListView { get; set; }

        public CarListAccessor()
        {
            this.Cars = new ObservableCollection<Car>();
            this.ListView = new ListViewAccessor<Car>();
        }
    }
}
