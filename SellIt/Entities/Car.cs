using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt.Entities
{
    public class Car
    {
        #region Attributs
        private long carID;
        private Category category;
        private int year;
        private int timeAssurancy;
        private bool avalaible;
        private int delayExchange;
        private int color;
        #endregion

        #region Properties
        public long CarID
        {
            get { return carID; }
            set { carID = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }
        
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    
        public int Color
        {
            get { return color; }
            set { color = value; }
        }       

        public bool Avalaible
        {
            get { return avalaible; }
            set { avalaible = value; }
        }


        

        public int TimeAssurancy
        {
            get { return timeAssurancy; }
            set { timeAssurancy = value; }
        }
       
        public int DelayExchange
        {
            get { return delayExchange; }
            set { delayExchange = value; }
        }
        #endregion
    }
}
