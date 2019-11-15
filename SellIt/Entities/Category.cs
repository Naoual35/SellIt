using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Category
      {
        #region Attributs
        private long categoryID;
        private string name;
        private Brand brand;
        private string description;
        private float tva;
        private List<Car> cars;
        private float price;
        #endregion

        #region Properties
        public long CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
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
      
        public Brand Brand
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
      
        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        #endregion

    }


}
