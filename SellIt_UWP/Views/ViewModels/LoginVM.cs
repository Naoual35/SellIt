using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Entities;
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
        public Seller Seller { get; set; }

        private string password = "password";
        private string login = "admin";

        private INavigationService navigationService;

        private String BtnConnexion { get { return "MainPage"; } }

        public ICommand BtnConnexionCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if ((this.Seller.Lastname==this.login) && (this.Seller.Password==this.password))
                    {
                        this.navigationService.NavigateTo("MainPage");
                    }
                    
                });
            }
        }

        public LoginVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            this.Seller = new Seller() { Lastname = "", Password = ""};

        }

    }
}
