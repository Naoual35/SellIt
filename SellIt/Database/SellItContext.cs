using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellIt.Entities;

namespace SellIt.Database
{
    public class SellItContext : DbContext
    {
        #region Attributs
        private DbSet<Car> dbCar;
        private DbSet<Category> dbCategory;
        private DbSet<Brand> dbBrand;
        #endregion

        #region Properties
        public DbSet<Car> DbCar
        {
            get { return dbCar; }
            set { dbCar = value; }
        }

        public DbSet<Category> DbCategory
        {
            get { return dbCategory; }
            set { dbCategory = value; }
        }

        

        public DbSet<Brand> DbBrand
        {
            get { return dbBrand; }
            set { dbBrand = value; }
        }

        #endregion

        #region Constructor
        SellItContext()
        {

        }
        #endregion

    }
}
