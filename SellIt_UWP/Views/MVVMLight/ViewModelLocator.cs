using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                navigationService.Configure("MainPage", typeof(MainPage));
                return navigationService;
            });
            SimpleIoc.Default.Register<LoginVM>();
        }

        public LoginVM BasePageInstance
        {
            get { return ServiceLocator.Current.GetInstance<LoginVM>(); }
        }


        //public BlankPageViewModel BlankPageInstance
        //{
        //    get { return ServiceLocator.Current.GetInstance<BlankPageViewModel>(); }
        //}
        //public OtherPageViewModel MyProperty
        //{
        //    get { return ServiceLocator.Current.GetInstance<OtherPageViewModel>(); }
        //}
    }
}
