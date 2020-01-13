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
using Windows.UI.Xaml.Controls;

namespace SellIt_UWP.Views.ViewModels
{
    public class OrderAdvancePageVM
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;

        public OrderAdvancePageAccessor Datas { get; set; }

        public OrderAdvancePageVM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            Datas = new OrderAdvancePageAccessor();
            SetupOrderList();
            SetupOrderEdit();
            SellerOrderShow();
            SetupOrderDelete();
            SetupClientList();
            SetupSellerList();
        }

        private void SellerOrderShow()
        {
            Datas.OrderShow.Order = new Order();
        }

        private void SetupOrderEdit()
        {
            Datas.OrderEdit.Button.Content = "Valider";
            Datas.OrderEdit.Button.Action = new RelayCommand(OrderEditCommand);
            Datas.OrderEdit.Order = new Order();
        }
        private void OrderEditCommand()
        {
            Order order = new Order();
            order.CopyFrom(Datas.OrderEdit.Order);
            //Datas.SellerList.Sellers.Add(seller);
            try
            {
                databaseService.SqliteConnection.Insert(order);
                Datas.OrderList.Orders.Add(order);
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

        private void SetupOrderList()
        {
            Datas.OrderList.Orders = new ObservableCollection<Order>();
            foreach (var item in databaseService.Orders)
            {
                Datas.OrderList.Orders.Add(item);
            }
            Datas.OrderList.ListView.SelectedItem = new Order();
            Datas.OrderList.ListView.SelectionChanged = new RelayCommand(OrderListSelectionChanged);
        }

        private void OrderListSelectionChanged()
        {
            Order order = Datas.OrderList.ListView.SelectedItem;
            if (order != null)
            {
                Datas.OrderShow.Order.CopyFrom(order);
            }
        }

        private void SetupOrderDelete()
        {
            Datas.OrderDelete.Button.Content = "Supprimer";
            Datas.OrderDelete.Button.Action = new RelayCommand(OrderDeleteCommand);
            Datas.OrderDelete.Order = new Order();
        }

        private void OrderDeleteCommand()
        {
            Order order = Datas.OrderList.ListView.SelectedItem;
            if (order != null)
            {
                try
                {
                    databaseService.SqliteConnection.Delete(order);
                    Datas.OrderList.Orders.Remove(order);
                    Datas.OrderDelete.Order.CopyFrom(new Order());
                    Datas.OrderShow.Order.CopyFrom(new Order());
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
                //Datas.SellerShow.Seller.CopyFrom(seller);
            }
        }

        private void SetupClientList()
        {
            Datas.ClientList.Clients = new ObservableCollection<Client>();
            foreach (var item in databaseService.Clients)
            {
                Datas.ClientList.Clients.Add(item);
            }
            Datas.ClientList.ListView.SelectedItem = new Client();
            Datas.ClientList.ListView.SelectionChanged = new RelayCommand(ClientListSelectionChanged);
        }

        private void ClientListSelectionChanged()
        {
            Client client = Datas.ClientList.ListView.SelectedItem;
            if (client != null)
            {
                //Datas.ClientShow.Client.CopyFrom(client);
            }
        }
    }
}
