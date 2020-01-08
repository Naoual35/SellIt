using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    public abstract class Person
    {
        #region Attributs
        private string lastname;
        private string firstname;
        private string address;
        private int postcode;
        private string phoneNumber;
        private string city;
        #endregion

        #region Properties
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
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
