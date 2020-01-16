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
    public class SellerPageVM
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;
        public SellerPageAccessor Datas { get; set; }

        public ICommand BtnRetourCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    this.navigationService.GoBack();
                });
            }
        }
        public SellerPageVM(INavigationService navigationService, DatabaseService databaseService)
        {           
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            Datas = new SellerPageAccessor();
            SetUpSellerEdit();
            SetupSellerList();
            SetupSellerShow();
            SetupSellerDelete();
        }

        private void SetupSellerDelete()
        {
            Datas.SellerDelete.Button.Content = "Supprimer";
            Datas.SellerDelete.Button.Action = new RelayCommand(SellerDeleteCommand);
            Datas.SellerDelete.Seller = new Seller();
        }

        private void SellerDeleteCommand()
        {
            Seller seller = Datas.SellerList.ListView.SelectedItem;
            if (seller != null)
            {
                try
                {
                    databaseService.SqliteConnection.Delete(seller);
                    Datas.SellerList.Sellers.Remove(seller);
                    Datas.SellerDelete.Seller.CopyFrom(new Seller());
                    Datas.SellerShow.Seller.CopyFrom(new Seller());
                }
                catch (Exception e)
                {
                    ContentDialog contentDialog = new ContentDialog();
                    contentDialog.Title = "Error";
                    contentDialog.Content = e.Message;
                    contentDialog.IsSecondaryButtonEnabled = false;
                    contentDialog.PrimaryButtonText = "ok";
                    contentDialog.ShowAsync();
                }
            }
        }

        private void SetupSellerShow()
        {
            Datas.SellerShow.Seller = new Seller();
        }

        private void SetupSellerList()
        {
            Datas.SellerList.Sellers = new ObservableCollection<Seller>();
            foreach (var item in databaseService.Sellers)
            {
                Datas.SellerList.Sellers.Add(item);
            }
            Datas.SellerList.ListView.SelectedItem = new Seller();
            Datas.SellerList.ListView.SelectionChanged = new RelayCommand(SellerListSelectionChanged);
        }

        private void SellerListSelectionChanged()
        {
            Seller seller = Datas.SellerList.ListView.SelectedItem;
            if (seller != null)
            {
                Datas.SellerShow.Seller.CopyFrom(seller);
                Datas.SellerDelete.Seller.CopyFrom(seller);
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
            //Datas.SellerList.Sellers.Add(seller);
            try
            {
                databaseService.SqliteConnection.Insert(seller);
                Datas.SellerList.Sellers.Add(seller);
            }
            catch (Exception e)
            {
                ContentDialog contentDialog = new ContentDialog();
                contentDialog.Title = "Error";
                contentDialog.Content = e.Message;
                contentDialog.IsSecondaryButtonEnabled = false;
                contentDialog.PrimaryButtonText = "ok";
                contentDialog.ShowAsync();
            }
        }
    }
}
