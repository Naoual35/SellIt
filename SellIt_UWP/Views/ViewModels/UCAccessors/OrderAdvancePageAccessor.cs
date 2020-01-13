using SellIt_UWP.Views.ViewModels.UCAccessors.Clients;
using SellIt_UWP.Views.ViewModels.UCAccessors.Orders;
using SellIt_UWP.Views.ViewModels.UCAccessors.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class OrderAdvancePageAccessor
    {
        public OrderListAccessor OrderList { get; set; }
        public OrderEditAccessor OrderEdit { get; set; }
        public OrderShowAccessor OrderShow { get; set; }
        public OrderDeleteAccessor OrderDelete { get; set; }
        public SellerListAccessor SellerList { get; set; }
        public ClientListAccessor ClientList { get; set; }

        public OrderAdvancePageAccessor()
        {
            this.OrderList = new OrderListAccessor();
            this.OrderEdit = new OrderEditAccessor();
            this.OrderShow = new OrderShowAccessor();
            this.OrderDelete = new OrderDeleteAccessor();
            this.SellerList = new SellerListAccessor();
            this.ClientList = new ClientListAccessor();
        }

    }
}
