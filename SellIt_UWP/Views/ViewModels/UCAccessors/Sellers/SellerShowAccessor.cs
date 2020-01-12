using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.Sellers
{
    public class SellerShowAccessor
    {
        public Seller Seller { get; set; }

        public SellerShowAccessor()
        {
            this.Seller = new Seller();
        }
    }
}
