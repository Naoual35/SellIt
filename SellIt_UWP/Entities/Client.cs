using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    [Table("Client")]
    public class Client : Person
    {
        private long clientId;

        [PrimaryKey,AutoIncrement]
        public long ClientId
        {
            get { return clientId; }
            set 
            { 
                clientId = value;
                OnPropertyChanged("ClientId");
            }
        }

        #region Methods
        public Client Copy()
        {
            Client client = new Client();
            client.Lastname = this.Lastname;
            client.Firstname = this.Firstname;
            client.Address = this.Address;
            client.Postcode = this.Postcode;
            client.PhoneNumber = this.PhoneNumber;
            client.City = this.City;
            client.ClientId = this.ClientId;
            return client;
        }

        public void CopyFrom(Client client)
        {
            this.Lastname = client.Lastname;
            this.Firstname = client.Firstname;
            this.Address = client.Address;
            this.Postcode = client.Postcode;
            this.PhoneNumber = client.PhoneNumber;
            this.City = client.City;
            this.ClientId = client.ClientId;
        }
        #endregion
    }
}
