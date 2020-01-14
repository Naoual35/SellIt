using SellIt_UWP.Views.ViewModels.UCAccessors.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class ClientPageAccessor
    {
        public ClientEditAccessor ClientEdit { get; set; }
        public ClientListAccessor ClientList { get; set; }
        public ClientShowAccessor ClientShow { get; set; }
        public ClientDeleteAccessor ClientDelete { get; set; }

        public ClientPageAccessor()
        {
            this.ClientEdit = new ClientEditAccessor();
            this.ClientList = new ClientListAccessor();
            this.ClientShow = new ClientShowAccessor();
            this.ClientDelete = new ClientDeleteAccessor();
        }
    }
}
