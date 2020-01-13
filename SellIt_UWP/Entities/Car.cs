using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellIt_UWP.Entities
{
    [Table("Car")]
    public class Car
    {
        #region Attributs
        private long carId;
        private string name;
        private int year;
        private int timeAssurancy;
        private bool avalaible;
        private int delayExchange;
        private string color;
        //private Category category;
        #endregion

        #region Properties


        [PrimaryKey, AutoIncrement, Column("carId")]
        public long CarId
        {
            get { return carId; }
            set { carId = value; }
        }

        [NotNull, Column("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public virtual Category Category
        //{
        //    get { return category; }
        //    set { category = value; }
        //}

        [NotNull, Column("year")]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        [NotNull, Column("color")]
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        [NotNull, Column("avalaible")]
        public bool Avalaible
        {
            get { return avalaible; }
            set { avalaible = value; }
        }

        [Column("timeAssurancy")]
        public int TimeAssurancy
        {
            get { return timeAssurancy; }
            set { timeAssurancy = value; }
        }

        [Column("delayExchange")]
        public int DelayExchange
        {
            get { return delayExchange; }
            set { delayExchange = value; }
        }

        #endregion

        #region Methods
        public Car Copy()
        {
            Car car = new Car();
            car.CarId = this.CarId;
            car.Name = this.Name;
            car.Year = this.Year;
            car.TimeAssurancy = this.TimeAssurancy;
            car.Avalaible = this.Avalaible;
            car.DelayExchange = this.DelayExchange;
            car.Color = this.Color;
            return car;
    }

        public void CopyFrom(Car car)
        {
            this.CarId = car.CarId;
            this.Name = car.Name;
            this.Year = car.Year;
            this.TimeAssurancy = car.TimeAssurancy;
            this.Avalaible = car.Avalaible;
            this.DelayExchange = car.DelayExchange;
            this.Color = car.Color;
        }
        #endregion
    }
}
