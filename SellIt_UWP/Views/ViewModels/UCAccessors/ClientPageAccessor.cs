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

        public ClientPageAccessor()
        {
            this.ClientEdit = new ClientEditAccessor();
        }
    }
}
