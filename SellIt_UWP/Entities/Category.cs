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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public virtual Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float Tva
        {
            get { return tva; }
            set { tva = value; }
        }

        #endregion

    }
}
