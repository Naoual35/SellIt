using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Views.ViewModels;
using SellIt_UWP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellIt_UWP.Services;

namespace SellIt_UWP.Views.MVVMLight
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //Register your services used here
            SimpleIoc.Default.Register<INavigationService>(() =>
            {
                var navigationService = new NavigationService();
                navigationService.Configure("BasePage", typeof(BasePage));
                navigationService.Configure("MainMenu", typeof(MainMenu));
                navigationService.Configure("FollowingCommands", typeof(FollowingCommands));
                navigationService.Configure("ClientCheckPage", typeof(ClientCheckPage));
                navigationService.Configure("SellerCheckPage", typeof(SellerCheckPage));
                navigationService.Configure("OrderCheckPage", typeof(OrderCheckPage));
                navigationService.Configure("OrderAdvanceCheckPage", typeof(OrderAdvanceCheckPage));
                return navigationService;
            });
            SimpleIoc.Default.Register<LoginVM>();
            SimpleIoc.Default.Register<MainMenuVM>();
            SimpleIoc.Default.Register<FollowingOrdersVM>();
            SimpleIoc.Default.Register<ClientPageVM>();
            SimpleIoc.Default.Register<SellerPageVM>();
            SimpleIoc.Default.Register<OrderPageVM>();
            SimpleIoc.Default.Register<OrderAdvancePageVM>();

            SimpleIoc.Default.Register<DatabaseService>(() =>
            {
                return new DatabaseService();
            }, true);
        }
        public LoginVM BasePageInstance
        {
            get { return ServiceLocator.Current.GetInstance<LoginVM>(); }
        }

        public MainMenuVM MainMenuInstance
        {
            get { return ServiceLocator.Current.GetInstance<MainMenuVM>(); }
        }

        public FollowingOrdersVM FollowingCommandsInstance
        {
            get { return ServiceLocator.Current.GetInstance<FollowingOrdersVM>(); }
        }

        public ClientPageVM ClientCheckPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<ClientPageVM>(); }
        }

        public SellerPageVM SellerCheckPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<SellerPageVM>(); }
        }

        public OrderPageVM OrderCheckPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<OrderPageVM>(); }
        }

        public OrderAdvancePageVM OrderAdvanceCheckPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<OrderAdvancePageVM>(); }
        }

    }
}
