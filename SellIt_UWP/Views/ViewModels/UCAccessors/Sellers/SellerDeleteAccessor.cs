using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Sellers
{
    public class SellerDeleteAccessor
    {
        public Seller Seller { get; set; }
        public ButtonAccessor Button { get; set; }
        public SellerDeleteAccessor()
        {
            this.Seller = new Seller();
            this.Button = new ButtonAccessor();
        }
    }
}
