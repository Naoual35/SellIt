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
    public class CarPageVM 
    {
        private INavigationService navigationService;
        private DatabaseService databaseService;
        public CarPageAccessor Datas { get; set; }

        public CarPageVM(INavigationService navigationService, DatabaseService databaseService)
        {
            this.navigationService = navigationService;
            this.databaseService = databaseService;
            SetupDatas();
        }

        private void SetupDatas()
        {
            Datas = new CarPageAccessor();
            SetupCarEdit();
            SetupCarList();
            SetupCarShow();
            SetupCarDelete();
        }

        private void SetupCarDelete()
        {
            Datas.CarDelete.Button.Content = "Supprimer";
            Datas.CarDelete.Button.Action = new RelayCommand(CarDeleteCommand);
            Datas.CarDelete.Car = new Car();
        }

        private void CarDeleteCommand()
        {
            Car car = Datas.CarList.ListView.SelectedItem;
            if (car != null)
            {
                try
                {
                    databaseService.SqliteConnection.Delete(car);
                    Datas.CarList.Cars.Remove(car);
                    Datas.CarDelete.Car.CopyFrom(new Car());
                    Datas.CarShow.Car.CopyFrom(new Car());
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

        private void SetupCarShow()
        {
            Datas.CarShow.Car = new Car();
        }

        private void SetupCarList()
        {
            Datas.CarList.Cars = new ObservableCollection<Car>();
            foreach (var item in databaseService.Cars)
            {
                Datas.CarList.Cars.Add(item);
            }
            Datas.CarList.ListView.SelectedItem = new Car();
            Datas.CarList.ListView.SelectionChanged = new RelayCommand(CarListSelectionChanged);
        }

        private void CarListSelectionChanged()
        {
            Car car = Datas.CarList.ListView.SelectedItem;
            if (car != null)
            {
                Datas.CarShow.Car.CopyFrom(car);
                Datas.CarDelete.Car.CopyFrom(car);
            }
        }

        private void SetupCarEdit()
        {
            Datas.CarEdit.Button.Content = "Valider";
            Datas.CarEdit.Button.Action = new RelayCommand(CarEditCommand);
            Datas.CarEdit.Car = new Car();
        }

        private void CarEditCommand()
        {
            Car car = new Car();
            car.CopyFrom(Datas.CarEdit.Car);
            
            try
            {
                databaseService.SqliteConnection.Insert(car);
                Datas.CarList.Cars.Add(car);
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
