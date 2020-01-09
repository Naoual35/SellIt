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

namespace SellIt_UWP.Views.Clients
{

    public sealed partial class ListClientUC : UserControl
    {
        public ObservableCollection<Client> ClientList { get; set; }
        public ListClientUC()
        {
            this.InitializeComponent();
            ClientList = new ObservableCollection<Client>();
            this.DataContext = ClientList;
        }

        private void MenuFlyoutDelete_Click(object sender, RoutedEventArgs e)
        {
            this.ClientList.Remove(sender as Client);
        }
    }
}
