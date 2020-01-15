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
        public SellItContext()
        {
            if (this.Database.CreateIfNotExists())
            {

                Brand peugeot = new Brand();
                peugeot.Name = "Peugeot";
                peugeot.Description = "la marque de voiture française Peugeot";
                this.dbBrand.Add(peugeot);
                this.SaveChanges();

                Brand citroen = new Brand();
                citroen.Name = "Citroën";
                citroen.Description = "la marque de voiture française Citroën";
                this.dbBrand.Add(citroen);
                this.SaveChanges();

                Brand renault = new Brand();
                renault.Name = "Renault";
                renault.Description = "la marque de voiture française Renault";
                this.dbBrand.Add(renault);
                this.SaveChanges();

                Brand volkswagen = new Brand();
                volkswagen.Name = "Volkswagen";
                volkswagen.Description = "la marque de voiture allemande Volkswagen";
                this.dbBrand.Add(volkswagen);
                this.SaveChanges();

                Category citPeugeot = new Category();
                citPeugeot.Name = "Citadine";
                citPeugeot.Description = "Petite voiture";
                citPeugeot.Tva = 0.2F;
                citPeugeot.Price = 2000F;
                citPeugeot.Brand = this.dbBrand.Find(peugeot.BrandId);
                this.dbCategory.Add(citPeugeot);
                
                this.SaveChanges();

                Category citRenault = new Category();
                citRenault.Name = "Citadine";
                citRenault.Description = "Petite voiture";
                citRenault.Tva = 0.2F;
                citRenault.Price = 2000F;
                citRenault.Brand = this.dbBrand.Find(renault.BrandId);
                this.dbCategory.Add(citRenault);
                this.SaveChanges();

                Category citCitroen = new Category();
                citCitroen.Name = "Citadine";
                citCitroen.Description = "Petite voiture";
                citCitroen.Tva = 0.2F;
                citCitroen.Price = 2000F;
                citCitroen.Brand = this.dbBrand.Find(citroen.BrandId);
                this.dbCategory.Add(citCitroen);
                this.SaveChanges();

                Category citVolkswagen = new Category();
                citVolkswagen.Name = "Citadine";
                citVolkswagen.Description = "Petite voiture";
                citVolkswagen.Tva = 0.2F;
                citVolkswagen.Price = 2000F;
                citVolkswagen.Brand = this.dbBrand.Find(volkswagen.BrandId);
                this.dbCategory.Add(citVolkswagen);
                this.SaveChanges();

                Category berPeugeot = new Category();
                berPeugeot.Name = "Berline";
                berPeugeot.Description = "Une berline classique";
                berPeugeot.Tva = 0.2F;
                berPeugeot.Price = 2000F;
                berPeugeot.Brand = this.dbBrand.Find(peugeot.BrandId);
                this.dbCategory.Add(berPeugeot);
                this.SaveChanges();

                Category monPeugeot = new Category();
                monPeugeot.Name = "Monospace";
                monPeugeot.Description = "Un monospace classique";
                monPeugeot.Tva = 0.2F;
                monPeugeot.Price = 3500F;
                monPeugeot.Brand = this.dbBrand.Find(peugeot.BrandId);
                this.dbCategory.Add(monPeugeot);
                this.SaveChanges();

                Category berRenault = new Category();
                berRenault.Name = "Berline";
                berRenault.Description = "Une berline classique";
                berRenault.Tva = 0.2F;
                berRenault.Price = 2000F;
                berRenault.Brand = this.dbBrand.Find(renault.BrandId);
                this.dbCategory.Add(berRenault);
                this.SaveChanges();

                Category berCitroen = new Category();
                berCitroen.Name = "Berline";
                berCitroen.Description = "Une berline classique";
                berCitroen.Tva = 0.2F;
                berCitroen.Price = 2000F;
                berCitroen.Brand = this.dbBrand.Find(citroen.BrandId);
                this.dbCategory.Add(berCitroen);
                this.SaveChanges();

                Category berVolkswagen = new Category();
                berVolkswagen.Name = "Berline";
                berVolkswagen.Description = "Une berline classique";
                berVolkswagen.Tva = 0.2F;
                berVolkswagen.Price = 2000F;
                berVolkswagen.Brand = this.dbBrand.Find(volkswagen.BrandId);
                this.dbCategory.Add(berVolkswagen);
                this.SaveChanges();

                Category breVolkswagen = new Category();
                breVolkswagen.Name = "Break";
                breVolkswagen.Description = "un break";
                breVolkswagen.Tva = 0.2F;
                breVolkswagen.Price = 2000F;
                breVolkswagen.Brand = this.dbBrand.Find(volkswagen.BrandId);
                this.dbCategory.Add(breVolkswagen);
                this.SaveChanges();

                Category monVolkswagen = new Category();
                monVolkswagen.Name = "Break";
                monVolkswagen.Description = "un break";
                monVolkswagen.Tva = 0.2F;
                monVolkswagen.Price = 2000F;
                monVolkswagen.Brand = this.dbBrand.Find(volkswagen.BrandId);
                this.dbCategory.Add(monVolkswagen);
                this.SaveChanges();

                Category breRenault = new Category();
                breRenault.Name = "Break";
                breRenault.Description = "un break";
                breRenault.Tva = 0.2F;
                breRenault.Price = 2000F;
                breRenault.Brand = this.dbBrand.Find(renault.BrandId);
                this.dbCategory.Add(breRenault);
                this.SaveChanges();

                Category monRenault = new Category();
                monRenault.Name = "Monospace";
                monRenault.Description = "Un monospace";
                monRenault.Tva = 0.2F;
                monRenault.Price = 2000F;
                monRenault.Brand = this.dbBrand.Find(renault.BrandId);
                this.dbCategory.Add(monRenault);
                this.SaveChanges();

                Car voiture = new Car();
                voiture.Name = "Peugeot 306";
                voiture.Year = 2000;
                voiture.TimeAssurancy = 2;
                voiture.Avalaible = true;
                voiture.DelayExchange = 1;
                voiture.Color = "Rouge";
                voiture.Category = this.dbCategory.Find(citPeugeot.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Peugeot 406";
                voiture.Year = 2002;
                voiture.TimeAssurancy = 2;
                voiture.Avalaible = true;
                voiture.DelayExchange = 1;
                voiture.Color = "Bleue";
                voiture.Category = this.dbCategory.Find(berPeugeot.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Peugeot 407";
                voiture.Year = 2003;
                voiture.TimeAssurancy = 2;
                voiture.Avalaible = true;
                voiture.DelayExchange = 1;
                voiture.Color = "Verte";
                voiture.Category = this.dbCategory.Find(berPeugeot.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Citroën DS";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Rouge";
                voiture.Category = this.dbCategory.Find(citCitroen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Xantia";
                voiture.Year = 2011;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Bleue";
                voiture.Category = this.dbCategory.Find(berCitroen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "C5";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Rouge";
                voiture.Category = this.dbCategory.Find(berCitroen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "C3";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Verte";
                voiture.Category = this.dbCategory.Find(citCitroen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "C2";
                voiture.Year = 2011;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Blanche";
                voiture.Category = this.dbCategory.Find(citCitroen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Espace";
                voiture.Year = 2015;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Noire";
                voiture.Category = this.dbCategory.Find(monRenault.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Laguna";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Blanche";
                voiture.Category = this.dbCategory.Find(berRenault.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Laguna";
                voiture.Year = 2011;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Noire";
                voiture.Category = this.dbCategory.Find(berRenault.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "4L";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Rouge";
                voiture.Category = this.dbCategory.Find(citRenault.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Polo";
                voiture.Year = 2011;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Verte";
                voiture.Category = this.dbCategory.Find(citVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Polo";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = true;
                voiture.DelayExchange = 2;
                voiture.Color = "Noire";
                voiture.Category = this.dbCategory.Find(citVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Passat";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = false;
                voiture.DelayExchange = 2;
                voiture.Color = "Blanche";
                voiture.Category = this.dbCategory.Find(berVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Passat";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = false;
                voiture.DelayExchange = 2;
                voiture.Color = "Bleue";
                voiture.Category = this.dbCategory.Find(breVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Golf";
                voiture.Year = 2015;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = false;
                voiture.DelayExchange = 2;
                voiture.Color = "Noire";
                voiture.Category = this.dbCategory.Find(citVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "806";
                voiture.Year = 2012;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = false;
                voiture.DelayExchange = 2;
                voiture.Color = "Rouge et noire";
                voiture.Category = this.dbCategory.Find(monPeugeot.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Touran";
                voiture.Year = 2016;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = false;
                voiture.DelayExchange = 2;
                voiture.Color = "Grise";
                voiture.Category = this.dbCategory.Find(monVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();

                voiture = new Car();
                voiture.Name = "Touran";
                voiture.Year = 2013;
                voiture.TimeAssurancy = 3;
                voiture.Avalaible = false;
                voiture.DelayExchange = 2;
                voiture.Color = "Noire";
                voiture.Category = this.dbCategory.Find(monVolkswagen.CategoryId);
                this.dbCar.Add(voiture);
                this.SaveChanges();


            }
            #endregion
        }

        public System.Data.Entity.DbSet<SellIt.Entities.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<SellIt.Entities.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<SellIt.Entities.Seller> Sellers { get; set; }
    }
}
