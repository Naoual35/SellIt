using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Orders
{
    public class OrderListAccessor
    {
        public ObservableCollection<Order> Orders { get; set; }
        public ListViewAccessor<Order> ListView { get; set; }

        public OrderListAccessor()
        {
            this.Orders = new ObservableCollection<Order>();
            this.ListView = new ListViewAccessor<Order>();
        }
    }
}
