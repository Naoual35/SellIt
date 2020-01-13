using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Login
{
    public class LoginAccessor
    {
        public Seller Seller { get; set; }
        public ObservableCollection<Seller> Sellers { get; set; }
        public ButtonAccessor Button { get; set; }

        public LoginAccessor()
        {
            this.Seller = new Seller();
            this.Sellers = new ObservableCollection<Seller>();
            this.Button = new ButtonAccessor();
        }
    }
}
