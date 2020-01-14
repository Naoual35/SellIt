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
    public class BrandPageVM
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;
        public BrandPageAccessor Datas { get; set; }

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
            SetupBrandShow();
            SetupBrandDelete();
        }

        private void SetupBrandDelete()
        {
            Datas.BrandDelete.Button.Content = "Supprimer";
            Datas.BrandDelete.Button.Action = new RelayCommand(BrandDeleteCommand);
            Datas.BrandDelete.Brand = new Brand();
        }

        private void BrandDeleteCommand()
        {
            Brand brand = Datas.BrandList.ListView.SelectedItem;
            if (brand != null)
            {
                try
                {
                    databaseService.SqliteConnection.Delete(brand);
                    Datas.BrandList.Brands.Remove(brand);
                    Datas.BrandDelete.Brand.CopyFrom(new Brand());
                    Datas.BrandShow.Brand.CopyFrom(new Brand());
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

        private void SetupBrandShow()
        {
            Datas.BrandShow.Brand = new Brand();
        }

        private void SetupBrandList()
        {
            Datas.BrandList.Brands = new ObservableCollection<Brand>();
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
                Datas.BrandDelete.Brand.CopyFrom(brand);
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
            //Datas.CategoryList.Categories.Add(Category);
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
