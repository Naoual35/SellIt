using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Sellers
{
    public class SellerListAccessor
    {
        public ObservableCollection<Seller> Sellers { get; set; }
        public ListViewAccessor<Seller> ListView { get; set; }

        public SellerListAccessor()
        {
            this.Sellers = new ObservableCollection<Seller>();
            this.ListView = new ListViewAccessor<Seller>();
        }
    }
}
