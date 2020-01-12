using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    
    public abstract class Person : INotifyPropertyChanged
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
        private string lastname;
        private string firstname;
        private string address;
        private int postcode;
        private string phoneNumber;
        private string city;
        #endregion

        #region Properties
        [Column("lastname")]
        [NotNull]
        public string Lastname
        {
            get { return lastname; }
            set
            { 
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        [Column("firstname")]
        [NotNull]
        public string Firstname
        {
            get { return firstname; }
            set
            { 
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        [Column("address")]
        [NotNull]
        public string Address
        {
            get { return address; }
            set
            { 
                address = value;
                OnPropertyChanged("Address");
            }
        }

        [Column("postcode")]
        [NotNull]
        public int Postcode
        {
            get { return postcode; }
            set
            {
               postcode = value;
                OnPropertyChanged("Postcode");
            }
        }

        [Column("city")]
        [NotNull]
        public string City
        {
            get { return city; }
            set
            { 
                city = value;
                OnPropertyChanged("City");
            }
        }

        [Column("phoneNumber")]
        [NotNull]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            { 
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        #endregion

    }
}
