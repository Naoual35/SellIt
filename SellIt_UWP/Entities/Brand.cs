using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.ComponentModel;

namespace SellIt_UWP.Entities
{
    public class Brand : INotifyPropertyChanged
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

        #region attributs
        private long brandId;
        private string name;
        private string description;

        #endregion

        #region properties

        [PrimaryKey,AutoIncrement]
        public long BrandId
        {
            get { return brandId; }
            set { brandId = value; }
        }

        [Column("name")]
        [NotNull]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [Column("description")]
        [NotNull]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
      
        public Brand Copy()
        {
            Brand brand = new Brand();
            brand.brandId = this.BrandId;
            brand.Name = this.Name;
            brand.Description = this.Description;          
            return brand;
        }

        public void CopyFrom(Brand brand)
        {
            //this.brandId = bran.Lastname;


            #endregion
        } 
}
