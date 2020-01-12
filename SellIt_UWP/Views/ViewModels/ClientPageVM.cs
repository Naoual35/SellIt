using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Views.ViewModels.UCAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels
{
    public class ClientPageVM
    {
        private INavigationService navigationService;
        public ClientPageAccessor Datas { get; set; }

        public ClientPageVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            throw new NotImplementedException();
        }
    }   
}
