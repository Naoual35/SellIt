using SellIt_UWP.Views.ViewModels.UCAccessors.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class SellerPageAccessor
    {
        public SellerEditAccessor SellerEdit { get; set; }
        public SellerListAccessor SellerList { get; set; }
        public SellerShowAccessor SellerShow { get; set; }
        public SellerDeleteAccessor SellerDelete { get; set; }

        public SellerPageAccessor()
        {
            this.SellerEdit = new SellerEditAccessor();
            this.SellerList = new SellerListAccessor();
            this.SellerShow = new SellerShowAccessor();
            this.SellerDelete = new SellerDeleteAccessor();
        }
    }
}
