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
    public class ClientPageVM
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;
        public ClientPageAccessor Datas { get; set; }

        public ClientPageVM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            Datas = new ClientPageAccessor();
            SetUpClientEdit();
            SetupClientList();
            SetupClientShow();
            SetupClientDelete();
        }

        private void SetupClientDelete()
        {
            Datas.ClientDelete.Button.Content = "Supprimer";
            Datas.ClientDelete.Button.Action = new RelayCommand(ClientDeleteCommand);
            Datas.ClientDelete.Client = new Client();
        }

        private void ClientDeleteCommand()
        {
            Client client = Datas.ClientList.ListView.SelectedItem;
            if (client != null)
            {
                try
                {
                    databaseService.SqliteConnection.Delete(client);
                    Datas.ClientList.Clients.Remove(client);
                    Datas.ClientDelete.Client.CopyFrom(new Client());
                    Datas.ClientShow.Client.CopyFrom(new Client());
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

        private void SetupClientShow()
        {
            Datas.ClientShow.Client = new Client();
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
                Datas.ClientShow.Client.CopyFrom(client);
                Datas.ClientDelete.Client.CopyFrom(client);
            }
        }

        private void SetUpClientEdit()
        {
            Datas.ClientEdit.Button.Content = "Valider";
            Datas.ClientEdit.Button.Action = new RelayCommand(ClientEditCommand);
            Datas.ClientEdit.Client = new Client();
        }

        private void ClientEditCommand()
        {
            Client client = new Client();
            client.CopyFrom(Datas.ClientEdit.Client);
            //Datas.ClientList.Clients.Add(client);
            try
            {
                databaseService.SqliteConnection.Insert(client);
                Datas.ClientList.Clients.Add(client);
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
