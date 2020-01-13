using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors.MainMenu2
{
    public class myButtonsAccessor
    {
        public ButtonAccessor BrandButton { get; set; }
        public ButtonAccessor CategoryButton { get; set; }
        public ButtonAccessor CarButton { get; set; }
        public ButtonAccessor SellerButton { get; set; }
        public ButtonAccessor ClientButton { get; set; }
        public ButtonAccessor OrderButton { get; set; }
        public ButtonAccessor OrderAdvanceButton { get; set; }
        public ButtonAccessor GoBackButton { get; set; }

        public myButtonsAccessor()
        {
            this.BrandButton = new ButtonAccessor();
            this.CategoryButton = new ButtonAccessor();
            this.CarButton = new ButtonAccessor();
            this.SellerButton = new ButtonAccessor();
            this.ClientButton = new ButtonAccessor();
            this.OrderButton = new ButtonAccessor();
            this.OrderAdvanceButton = new ButtonAccessor();
            this.GoBackButton = new ButtonAccessor();
        }
    }
}
