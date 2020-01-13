using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    public class Category : INotifyPropertyChanged
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
        private long categoryId;
        private string name;
        private Brand brand;
        private long brandId;
        private string description;
        private float tva;
        private float price;
        #endregion

        #region Properties

        [PrimaryKey, AutoIncrement]
        public long CategoryId
        {
            get { return categoryId; }
            set 
            { 
                categoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }

        [Column("name")]
        [NotNull]
        public string Name
        {
            get { return name; }
            set
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }

        [Column("description")]
        [NotNull]
        public string Description
        {
            get { return description; }
            set
            { 
                description = value;
                OnPropertyChanged("Description");
            }
        }

        [OneToOne("brandId")]
        public virtual Brand Brand
        {
            get { return brand; }
            set
            { 
                brand = value;
                OnPropertyChanged("Brand");
            }
        }

        [ForeignKey(typeof(Brand))]
        public long BrandId
        {
            get { return brandId; }
            set
            { 
                brandId = value;
                OnPropertyChanged("BrandId");
            }
        }

        [Column("price")]
        [NotNull]
        public float Price
        {
            get { return price; }
            set
            { 
                price = value;
                OnPropertyChanged("Price");
            }
        }

        [Column("tva")]
        [NotNull]
        public float Tva
        {
            get { return tva; }
            set
            { 
                tva = value;
                OnPropertyChanged("Tva");
            }
        }
     

        public Category Copy()
        {
            Category category = new Category();
            category.CategoryId = this.CategoryId;
            category.Name = this.Name;
            category.Description = this.Description;
            category.Price = this.Price;
            category.Tva = this.Tva;
            if (this.Brand != null)
            {
                category.Brand = this.Brand.Copy();
            }

            return category;
        }
        public void CopyFrom(Category category)
        {
 
            this.CategoryId = category.CategoryId;
            this.Name = category.Name;
            this.Description = category.Description;
            this.Price = category.Price;
            this.Tva = category.Tva;
            if (category.Brand != null)
            {
                this.Brand = category.Brand;
            }
        }
        #endregion

    }
}
