using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Clients
{
    public class ClientListAccessor
    {
        public ObservableCollection<Client> Clients { get; set; }
        public ListViewAccessor<Client> ListView { get; set; }

        public ClientListAccessor()
        {
            this.Clients = new ObservableCollection<Client>();
            this.ListView = new ListViewAccessor<Client>();
        }
    }
}
