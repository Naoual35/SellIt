using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.FollowingOrders
{
    public class SelectClientOrderListsAccessor
    {
        public ObservableCollection<Client> Clients { get; set; }
        public ListViewAccessor<Client> ListView { get; set; }

        public ButtonAccessor Button { get; set; }

        public SelectClientOrderListsAccessor()
        {
            this.Clients = new ObservableCollection<Client>();
            this.ListView = new ListViewAccessor<Client>();
            this.Button = new ButtonAccessor();
        }
    }
}
