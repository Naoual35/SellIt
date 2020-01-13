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
    public class BrandPageVM
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;
        public BrandPageAccessor Datas { get; set; }

        public BrandPageVM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            Datas = new BrandPageAccessor();
            SetUpBrandEdit();
            SetupBrandList();
            SetupShow();
        }

        private void SetupShow()
        {
            throw new NotImplementedException();
        }

        private void SetupBrandShow()
        {
            Datas.BrandShow.Brand = new Brand();
        }

        private void SetupBrandList()
        {
            Datas.BrandList.Brands  = new ObservableCollection<Brand>();
            foreach (var item in databaseService.Brands)
            {
                Datas.BrandList.Brands.Add(item);
            }
            Datas.BrandList.ListView.SelectedItem = new Brand();
            Datas.BrandList.ListView.SelectionChanged = new RelayCommand(BrandListSelectionChanged);
        }


        private void BrandListSelectionChanged()
        {
            Brand brand = Datas.BrandList.ListView.SelectedItem;
            if (brand != null)
            {
                Datas.BrandShow.Brand.CopyFrom(brand);
            }
        }

        private void SetUpBrandEdit()
        {
            Datas.BrandEdit.Button.Content = "Valider";
            Datas.BrandEdit.Button.Action = new RelayCommand(BrandEditCommand);
            Datas.BrandEdit.Brand = new Brand();
        }

        private void BrandEditCommand()
        {
            Brand brand = new Brand();
            brand.CopyFrom(Datas.BrandEdit.Brand);
            //Datas.BrandList.Brands.Add(brand);
            try
            {
                databaseService.SqliteConnection.Insert(brand);
                Datas.BrandList.Brands.Add(brand);
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
