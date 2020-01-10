using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Entities;
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
        public Client ClientShow { get; set; }
        public Client ClientEdit { get; set; }

        public ObservableCollection<Client> ClientList { get; set; }
        
        private INavigationService navigationService;

        public FollowingOrdersVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ClientList = new ObservableCollection<Client>();
            ClientList.Add(new Client {Firstname = "Lolo", Lastname = "popo" });
            ClientList.Add(new Client { Firstname = "Lala", Lastname = "popo" });
            ClientList.Add(new Client { Firstname = "Lulu", Lastname = "popo" });

        }
    }
}
