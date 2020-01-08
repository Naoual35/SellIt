using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    public class Seller : Person, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        #region Attributs
        private long sellerId;
        private DateTime dateOfBirth;
        private List<Order> orders;
        private string password;
        #endregion

        #region Properties
        public long SellerId
        {
            get { return sellerId; }
            set
            { 
                sellerId = value;
                OnPropertyChanged("SellerId");
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set 
            {
                orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        #endregion
    }
}
