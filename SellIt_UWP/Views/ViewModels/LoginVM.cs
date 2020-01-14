using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Entities;
using SellIt_UWP.Services;
using SellIt_UWP.Views.ViewModels.UCAccessors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace SellIt_UWP.Views.ViewModels
{
    public class LoginVM : ViewModelBase
    {
        public LoginPageAccessor Datas { get; set; }

        private INavigationService navigationService;
        private DatabaseService databaseService;

        public LoginVM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetUpDatas();
        }

        private void SetUpDatas()
        {
            Datas = new LoginPageAccessor();
            SetUpLogin();
            SetupListSeller();
        }

        private void SetupListSeller()
        {
            Datas.Login.Sellers = new ObservableCollection<Seller>();
            foreach (var item in this.databaseService.Sellers)
            {
                Datas.Login.Sellers.Add(item);
            }
        }

        private void SetUpLogin()
        {
            bool tag = false;
            Datas.Login.Seller = new Seller();
            Datas.Login.Button.Content = "Connexion";
            Datas.Login.Button.Action = new RelayCommand(() =>
            {
                foreach (var item in this.databaseService.Sellers)
                {
                    if ((item.Lastname.Equals(this.Datas.Login.Seller.Lastname)) && (item.Password.Equals(this.Datas.Login.Seller.Password)))
                    {
                        tag = true;
                        break;
                    }
                }

                if (tag)
                {
                    this.navigationService.NavigateTo("MainMenu2");
                }
                else
                {
                    ContentDialog contentDialog = new ContentDialog();
                    contentDialog.Title = "Error";
                    contentDialog.Content = "Login ou mot de passe incorrect";
                    contentDialog.IsSecondaryButtonEnabled = false;
                    contentDialog.PrimaryButtonText = "ok";
                    contentDialog.ShowAsync();
                }

                this.navigationService.NavigateTo("MainMenu2");
            });
        }
    }
}
