using SellIt_UWP.Views.ViewModels.UCAccessors.FollowingOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class FollowingOrdersPageAccessor
    {
        public ClientShowAccessor ClientShow { get; set; }
        public SelectClientOrderListsAccessor ClientList { get; set; }
        public FollowingOrdersPageAccessor()
        {
            this.ClientShow = new ClientShowAccessor();
            this.ClientList = new SelectClientOrderListsAccessor();
        }
    }
}
