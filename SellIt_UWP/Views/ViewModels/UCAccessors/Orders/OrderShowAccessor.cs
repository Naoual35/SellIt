using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Orders
{
    public class OrderShowAccessor
    {
        public Order Order { get; set; }

        public OrderShowAccessor()
        {
            this.Order = new Order();
        }
    }
}
