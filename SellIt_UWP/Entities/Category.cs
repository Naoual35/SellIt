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
        private string description;
        private float tva;
        private float price;
        #endregion

        #region Properties

        public long CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
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

        [OneToOne("brandID")]
        public virtual Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        [Column("price")]
        [NotNull]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        [Column("tva")]
        [NotNull]
        public float Tva
        {
            get { return tva; }
            set { tva = value; }
        }
        


        [ForeignKey(typeof(Brand))]
        public long brandID
        {
            get { return brandID; }
            set { brandID = value; }
        }

        public Category Copy()
        {
            Category category = new Category();
            category.categoryId = this.CategoryId;
            category.Name = this.Name;
            category.Description = this.Description;
            if (this.Brand != null)
            {
                category.Brand = this.Brand.Copy();
            }

            return category;
        }
        public void CopyFrom(Category category)
        {
 
            this.categoryId = category.CategoryId;
            this.Name = category.Name;
            this.Description = category.Description;
            if (category.Brand != null)
            {
                this.Brand = category.Brand;
            }
        }
        #endregion

    }
}
