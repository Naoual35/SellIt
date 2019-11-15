using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Person
    {
        #region Attributs
        private long clientID;
        private string lastname;
        private string firstname;
        private string address;
        private int postcode;
        private string phoneNumber;
        private string city;
        #endregion

        #region Properties
        public long ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string Lastname
        {
            get { return Lastname; }
            set { Lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        #endregion
    }
}
