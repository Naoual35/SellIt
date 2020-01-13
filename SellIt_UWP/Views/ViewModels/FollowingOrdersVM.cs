using GalaSoft.MvvmLight;
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
    public class FollowingOrdersVM : ViewModelBase
    {
        public FollowingOrdersPageAccessor Datas { get; set; }
        private INavigationService navigationService;

        public FollowingOrdersVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            SetUpDatas();
        }

        private void SetUpDatas()
        {
            Datas = new FollowingOrdersPageAccessor();
            SetUpClientShow();
            SetUpCLientList();
            SetUpButton();
        }

        private void SetUpButton()
        {
            Datas.ClientList.Button.Content = "Retour";
            Datas.ClientList.Button.Action = new RelayCommand(() =>
            {
                this.navigationService.NavigateTo("BasePage");
            });
        }

        private void SetUpClientShow()
        {
            Datas.ClientShow.Client = new Client();
        }

        private void SetUpCLientList()
        {
            Datas.ClientList.Clients = new ObservableCollection<Client>();
            Datas.ClientList.Clients.Add(new Client() 
            {
                Lastname = "Dorian",
                Firstname = "John",
                Address = "là",
                Postcode = 5,
                PhoneNumber = "02 99 00 00 00",
                City = "Rennes"

            });
            Datas.ClientList.Clients.Add(new Client()
            {
                Lastname = "Carpenter",
                Firstname = "John",
                Address = "ici",
                Postcode = 5,
                PhoneNumber = "02 99 00 00 00",
                City = "Rennes"
            });
            Datas.ClientList.Clients.Add(new Client()
            {
                Lastname = "Haddock",
                Firstname = "Archibald",
                Address = "ailleurs",
                Postcode = 5,
                PhoneNumber = "02 99 00 00 00",
                City = "Rennes"
            });
            Datas.ClientList.ListView.SelectedItem = new Client();
            Datas.ClientList.ListView.SelectionChanged = new RelayCommand(ClientListSelectionChanged);

        }

        private void ClientListSelectionChanged()
        {
            Client client = Datas.ClientList.ListView.SelectedItem;
            if (client!=null)
            {
                Datas.ClientShow.Client.CopyFrom(client);
            }
        }
    }
}
