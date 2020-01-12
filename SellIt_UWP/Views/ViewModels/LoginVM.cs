using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SellIt_UWP.Views.ViewModels
{
    public class LoginVM : ViewModelBase
    {
        public LoginPageAccessor Datas { get; set; }

        private string password = "password";
        private string login = "Simonetto";

        private INavigationService navigationService;

        public LoginVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            SetUpDatas();
        }

        private void SetUpDatas()
        {
            Datas = new LoginPageAccessor();
            SetUpLogin();
        }

        private void SetUpLogin()
        {
            Datas.Login.Seller = new Seller();
            Datas.Login.Button.Content = "Connexion";
            Datas.Login.Button.Action = new RelayCommand(() =>
            {
                if ((this.Datas.Login.Seller.Lastname == this.login) && (this.Datas.Login.Seller.Password == this.password))
                {
                    this.navigationService.NavigateTo("FollowingCommands");
                }

            });
        }
    }
}
