﻿using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SellIt_UWP.Entities;
using SellIt_UWP.Services;
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
    public class CategoryPageVM
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;
        public CategoryPageAccessor Datas { get; set; }

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

        public CategoryPageVM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupDatas();
            
        }

        private void SetupDatas()
        {
            Datas = new CategoryPageAccessor();
            SetUpCategoryEdit();
            SetupCategoryList();
            SetupCategoryShow();
            SetupCategoryDelete();
        }

        private void SetupCategoryDelete()
        {
            Datas.CategoryDelete.Button.Content = "Supprimer";
            Datas.CategoryDelete.Button.Action = new RelayCommand(CategoryDeleteCommand);
            Datas.CategoryDelete.Category = new Category();
        }

        private void CategoryDeleteCommand()
        {
            Category category = Datas.CategoryList.ListView.SelectedItem;
            if (category != null)
            {
                try
                {
                    databaseService.SqliteConnection.Delete(category);
                    Datas.CategoryList.Categories.Remove(category);
                    Datas.CategoryDelete.Category.CopyFrom(new Category());
                    Datas.CategoryShow.Category.CopyFrom(new Category());
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

        private void SetupCategoryShow()
        {
            Datas.CategoryShow.Category = new Category();
        }

        private void SetupCategoryList()
        {
            Datas.CategoryList.Categories = new ObservableCollection<Category>();
            foreach (var item in databaseService.Categories)
            {
                Datas.CategoryList.Categories.Add(item);
            }
            Datas.CategoryList.ListView.SelectedItem = new Category();
            Datas.CategoryList.ListView.SelectionChanged = new RelayCommand(CategoryListSelectionChanged);
        }


        private void CategoryListSelectionChanged()
        {
            Category category = Datas.CategoryList.ListView.SelectedItem;
            if (category != null)
            {
                Datas.CategoryShow.Category.CopyFrom(category);
                Datas.CategoryDelete.Category.CopyFrom(category);
            }
        }

        private void SetUpCategoryEdit()
        {
            Datas.CategoryEdit.Button.Content = "Valider";
            Datas.CategoryEdit.Button.Action = new RelayCommand(CategoryEditCommand);
            Datas.CategoryEdit.Category= new Category();
        }

        private void CategoryEditCommand()
        {
            Category category = new Category();
            category.CopyFrom(Datas.CategoryEdit.Category);
            //Datas.CategoryList.Categories.Add(Category);
            try
            {
                databaseService.SqliteConnection.Insert(category);
                Datas.CategoryList.Categories.Add(category);
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
