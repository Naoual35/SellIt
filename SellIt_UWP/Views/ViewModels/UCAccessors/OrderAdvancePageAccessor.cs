﻿using SellIt_UWP.Views.ViewModels.UCAccessors.Clients;
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
        public OrderEditAccessor OrderEdit { get; set; }
        public SellerListAccessor SellerList { get; set; }
        public ClientListAccessor ClientList { get; set; }

        public OrderAdvancePageAccessor()
        {
            this.OrderEdit = new OrderEditAccessor();
            this.SellerList = new SellerListAccessor();
            this.ClientList = new ClientListAccessor();
        }

    }
}
