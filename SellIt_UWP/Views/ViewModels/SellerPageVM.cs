using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Entities;
using SellIt_UWP.Views.ViewModels.UCAccessors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Views.ViewModels
{
    public class SellerPageVM
    {
        private INavigationService navigationService;
        public SellerPageAccessor Datas { get; set; }

        public SellerPageVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            Datas = new SellerPageAccessor();
            SetUpSellerEdit();
            SetupSellerList();
            SetupSellerShow();
        }

        private void SetupSellerShow()
        {
            Datas.SellerShow.Seller = new Seller();
        }

        private void SetupSellerList()
        {
            Datas.SellerList.Sellers = new ObservableCollection<Seller>();
            //foreach (var item in databaseService.Roles)
            //{
            //    Datas.RoleList.Roles.Add(item);
            //}
            Datas.SellerList.ListView.SelectedItem = new Seller();
            Datas.SellerList.ListView.SelectionChanged = new RelayCommand(SellerListSelectionChanged);
        }

        private void SellerListSelectionChanged()
        {
            Seller seller = Datas.SellerList.ListView.SelectedItem;
            if (seller != null)
            {
                Datas.SellerShow.Seller.CopyFrom(seller);
            }
        }

        private void SetUpSellerEdit()
        {
            Datas.SellerEdit.Button.Content = "Valider";
            Datas.SellerEdit.Button.Action = new RelayCommand(SellerEditCommand);
            Datas.SellerEdit.Seller = new Seller();
        }

        private void SellerEditCommand()
        {
            Seller seller = new Seller();
            seller.CopyFrom(Datas.SellerEdit.Seller);
            Datas.SellerList.Sellers.Add(seller);
            //try
            //{
            //    databaseService.SqliteConnection.Insert(role);
            //    Datas.RoleList.Roles.Add(role);
            //}
            //catch (Exception e)
            //{
            //    ContentDialog contentDialog = new ContentDialog();
            //    contentDialog.Title = "Error";
            //    contentDialog.Content = e.Message;
            //    contentDialog.IsSecondaryButtonEnabled = false;
            //    contentDialog.PrimaryButtonText = "ok";
            //    contentDialog.ShowAsync();
            //}
        }
    }
}
