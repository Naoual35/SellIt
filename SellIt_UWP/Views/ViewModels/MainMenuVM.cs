using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SellIt_UWP.Views.ViewModels
{
    public class MainMenuVM 
    {
       // public Seller Seller { get; set; }

        private INavigationService navigationService;

        private String BtnRetour { get { return "BasePage"; } }

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

       
        public MainMenuVM(INavigationService navigationService)
        {
            this.navigationService = navigationService;         
        }
    }
}
