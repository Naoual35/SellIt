using SellIt_UWP.Views.ViewModels.UCAccessors.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class OrderPageAccessor
    {
        public OrderEditAccessor OrderEdit { get; set; }
        public OrderListAccessor OrderList { get; set; }
        public OrderShowAccessor OrderShow { get; set; }
        public OrderDeleteAccessor OrderDelete { get; set; }

        public OrderPageAccessor()
        {
            this.OrderEdit = new OrderEditAccessor();
            this.OrderList = new OrderListAccessor();
            this.OrderShow = new OrderShowAccessor();
            this.OrderDelete = new OrderDeleteAccessor();
        }
    }
}
