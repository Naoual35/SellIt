﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    public class Seller : Person
    {

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

        #region Methods
        public Seller Copy()
        {
            Seller seller = new Seller();
            seller.Lastname = this.Lastname;
            seller.Firstname = this.Firstname;
            seller.Address = this.Address;
            seller.Postcode = this.Postcode;
            seller.PhoneNumber = this.PhoneNumber;
            seller.City = this.City;
            seller.SellerId = this.SellerId;
            seller.DateOfBirth = this.DateOfBirth;
            seller.Password = this.Password;
            return seller;
        }

        public void CopyFrom(Seller seller)
        {
            this.Lastname = seller.Lastname;
            this.Firstname = seller.Firstname;
            this.Address = seller.Address;
            this.Postcode = seller.Postcode;
            this.PhoneNumber = seller.PhoneNumber;
            this.City = seller.City;
            this.SellerId = seller.SellerId;
            this.DateOfBirth = seller.DateOfBirth;
            this.Password = seller.Password;
        }
        #endregion
    }
}