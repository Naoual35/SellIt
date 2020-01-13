using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.FollowingOrders
{
    public class ClientShowAccessor
    {
        public Client Client { get; set; }

        public ClientShowAccessor()
        {
            this.Client = new Client();
        }
    }
}
