using SellIt_UWP.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace SellIt_UWP.Views
{
 
    public sealed partial class ShowSellerUC : UserControl
    {
        public Seller Seller { get; set; }

        public ObservableCollection<Seller> SellerList { get; set; }

        public ShowSellerUC()
        {
            this.InitializeComponent();

            this.Seller = new Seller();
            this.SellerList = new ObservableCollection<Seller>();

            for (int i = 0; i < 5; i++)
            {
                this.SellerList.Add(new Seller
                {
                    Lastname = "Nom " + i,
                    Firstname = "Prénom " + i,
                    Address = "Adresse " + i,
                    Postcode = 35000 + i,
                    PhoneNumber = "029900000" + i,
                    City = " Ville " + i,
                    DateOfBirth = new DateTime(1986,10,10)
                });
            }

            this.DataContext = this;

        }
    }
}
