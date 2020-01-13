using SellIt_UWP.Views.ViewModels.UCAccessors.Commons;
using SellIt_UWP.Views.ViewModels.UCAccessors.MainMenu2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels.UCAccessors
{
    public class MainMenu2Accessor
    {
        public myButtonsAccessor myButtons { get; set; }

        public MainMenu2Accessor()
        {
            this.myButtons = new myButtonsAccessor();
        }
    }
}
