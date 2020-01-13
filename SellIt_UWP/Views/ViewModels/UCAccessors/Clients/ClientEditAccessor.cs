using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Clients
{
    public class ClientEditAccessor
    {
        public Client Client { get; set; }
        public ButtonAccessor Button { get; set; }
        public ClientEditAccessor()
        {
            this.Client = new Client();
            this.Button = new ButtonAccessor();
        }
    }
}
