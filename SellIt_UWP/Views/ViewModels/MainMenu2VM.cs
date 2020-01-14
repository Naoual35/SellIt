using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Services;
using SellIt_UWP.Views.ViewModels.UCAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels
{
    public class MainMenu2VM
    {
        private INavigationService navigationService;
        public DatabaseService databaseService { get; set; }
        public MainMenu2Accessor Datas { get; set; }

        public MainMenu2VM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupButtons();
        }

        private void SetupButtons()
        {
            Datas = new MainMenu2Accessor();
            Datas.myButtons.GoBackButton.Content = "Retour";

            Datas.myButtons.GoBackButton.Action = new RelayCommand(() =>
            {
                this.navigationService.GoBack();
            });

            Datas.myButtons.CategoryButton.Content = "Catégories";

            Datas.myButtons.CategoryButton.Action = new RelayCommand(() =>
            {
                this.navigationService.NavigateTo("CategoryCheckPage");
            });

            Datas.myButtons.CarButton.Content = "Voitures";

            Datas.myButtons.CarButton.Action = new RelayCommand(() =>
            {
                this.navigationService.NavigateTo("CarCheckPage");
            });

            Datas.myButtons.SellerButton.Content = "Vendeurs";

            Datas.myButtons.SellerButton.Action = new RelayCommand(() =>
            {
                this.navigationService.NavigateTo("SellerCheckPage");
            });

            Datas.myButtons.ClientButton.Content = "Clients";

            Datas.myButtons.ClientButton.Action = new RelayCommand(() =>
            {
                this.navigationService.NavigateTo("ClientCheckPage");
            });

            Datas.myButtons.OrderButton.Content = "Commandes";

            Datas.myButtons.OrderButton.Action = new RelayCommand(() =>
            {
                this.navigationService.NavigateTo("OrderCheckPage");
            });


        }
    }
}
