using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Orders
{
    public class OrderEditAccessor
    {
        public Order Order { get; set; }
        public ButtonAccessor Button { get; set; }
        public OrderEditAccessor()
        {
            this.Order = new Order();
            this.Button = new ButtonAccessor();
        }
    }
}
