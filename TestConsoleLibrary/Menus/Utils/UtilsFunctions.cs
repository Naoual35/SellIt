using SellIt.Database;
using SellIt.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleLibrary.Menus.Utils
{
    class UtilsFunctions
    {
        public static long CreateBrandByConsole()
        {
            long result = 0;
            Brand brand = new Brand();

            Console.WriteLine("Create Brand :\n");

            using (var db = new SellItContext())
            {
                // On vérifie que le nom n'est pas utilisé par une autre marque:
                bool tag = false; // sortie de do si tag (tag==true)
                string choice = null;
                do
                {
                    choice = GetString("Enter a new brand name :");
                    int count = 0;
                    foreach (var item in db.DbBrand.ToList())
                    {
                        if (choice.Equals(item.Name))
                        {
                            // choice est déjà pris, pas la peine de tester les autres
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }

                    if (count == db.DbBrand.Count())// Si count vaut la taille de la liste de brand, c'est qu'on a parcouru DbBrand sans rencontrer choice
                    {
                        tag = true; // -> sortie de boucle, choice est valide
                    }
                    //else : count < taille : on s'est arrêté dans le foreach car choice est déja pris comme nom, tag reste false pour boucler
                } while (!tag);

                brand.Name = choice;
                brand.Description = GetString("\nEnter a description :");
                db.DbBrand.Add(brand);
                db.SaveChanges();

                foreach(var item in db.DbBrand.ToList())
                {
                    if(item.Name.Equals(choice))
                    {
                        result = item.BrandId;
                        break;
                    }
                }
            }

            return result;
        }

        public static long CreateCategoryByConsole(long brandId)
        {
            Category category = null;
            long result = -1;
            string schoice = null;
            int count;
            bool tag = false;
            /*
            private float tva;
            private float price;*/
            using(var db = new SellItContext())
            {
                do
                {
                    count = 0;
                    schoice = GetString("Enter a name category");
                    foreach(var item in db.DbCategory.ToList())
                    {
                        if(item.Name.Equals(schoice))
                        {
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    
                    if(count.Equals(db.DbCategory.Count()))
                    {
                        tag = true;
                    }
                } while (!tag);

                category.Name = schoice;

                category.Description = GetString("Enter a description");

                category.Tva = GetFloatLimitsIncluded("Enter a tva", 0F, 20F);

                category.Price = GetFloatLimitsIncluded("Enter a tva", 0F, 20F);

                category.Brand = db.DbBrand.Find(brandId);
                db.DbCategory.Add(category);
                db.SaveChanges();

                foreach(var item in db.DbCategory.ToList())
                {
                    if(item.Name.Equals(schoice))
                    {
                        result = item.CategoryId;
                    }
                }
            }
            
            return result;
        }

        public static long CreateCarByConsole()
        {
            Car car = new Car();
            long categoryId = -1;
            long brandId = -1;
            long carId = -1;
            int? choice = null;
            int? choice2 = null;
            bool tag = false;

            Console.WriteLine("Creating a new car\n");

            car.Name = GetString("Enter a car name\n");

            car.Year = GetIntLimitsIncluded("Enter a year",1980,2019);

            car.Color = GetString("Enter a color\n");

            car.Year = GetIntLimitsIncluded("Enter a Time assurancy", 0, 5);

            car.DelayExchange = GetIntLimitsIncluded("Enter a delay of exchange", 0, 5);

            car.Avalaible = true;

            Console.WriteLine("Category choice\n");

            using(var db = new SellItContext())
            {
                Console.WriteLine("List of existing categories :\n");
                foreach(var item in db.DbCategory.Include(x=>x.Brand).ToList())
                {
                    Console.WriteLine("Id : "+item.CategoryId+".  "+item.Name+" of "+item.Brand.Name+"\n");
                }
                Console.WriteLine("\n");

                tag = false;
                do
                {
                    choice = UtilsFunctions.GetIntChoice("Choose Category by Id or -1 if category does not exist:", 1, int.MaxValue);
                    foreach (var item in db.DbCategory.ToList())
                    {
                        if( (choice == item.CategoryId) | (choice == -1) )
                        {
                            tag = true;
                            break;
                        }
                    }
                } while (!tag);

                if(choice==-1) // Creation d'une nouvelle catégorie
                {
                    Console.WriteLine("List of existing brands :\n");
                    foreach (var item in db.DbBrand.ToList())
                    {
                        Console.WriteLine("Id : " + item.BrandId + " " + item.Name);
                    }
                    Console.WriteLine("\n");

                    tag = false;
                    do
                    {
                        choice2 = UtilsFunctions.GetIntChoice("Choose Brand by Id or -1 if brand does not exist:", 1, int.MaxValue);
                        foreach (var item in db.DbCategory.ToList())
                        {
                            if ((choice2 == item.CategoryId) | (choice2 == -1))
                            {
                                tag = true;
                                break;
                            }
                        }
                    } while (!tag);

                    if(choice2==-1)
                    {
                        brandId = CreateBrandByConsole();
                    }
                    else
                    {
                        brandId = (long)choice2;
                    }

                    Console.WriteLine("For Info, here are existing categories of car in the database :");
                    foreach(var item in getCarTypeList())
                    {
                        Console.WriteLine(item);
                    }

                    categoryId = CreateCategoryByConsole(brandId);
                    car.Category = db.DbCategory.Find(categoryId);
                    db.DbCar.Add(car);

                    foreach(var item in db.DbCar.ToList())
                    {
                        if(item.Name.Equals(car.Name))
                        {
                            carId = item.CarId;
                        }
                    }
                }
            }
            return carId;
        }



        public static List<string> getCarTypeList()
        {
            List<string> liste = new List<string>();

            using(var db = new SellItContext())
            {
                foreach(var item in db.DbCategory.ToList())
                {
                    liste.Add(item.Name);
                }
            }

            liste.Sort();
            IEnumerable<string> iListe =  liste.Distinct();
            liste = iListe.ToList();

            return liste;
        }

        public static string GetString(string question)
        {
            string result;
            Console.WriteLine(question);
            result = Console.ReadLine();
            return result;
        }

        public static int? GetIntChoice(string question, int min, int max)
        {
            int? result = null;
            int outResult = 0;
            string userChoice;

            do
            {
                Console.WriteLine(question);
                userChoice = Console.ReadLine();

            } while (!int.TryParse(userChoice, out outResult) || result < min || result > max);
            result = outResult;
            return result;
        }

        public static float GetFloatChoice(string question, float min, float max)
        {
            float result = 0F;
            float outResult = 0F;
            string userChoice;

            do
            {
                Console.WriteLine(question);
                userChoice = Console.ReadLine();

            } while (!float.TryParse(userChoice, out outResult) || result < min || result > max);
            result = outResult;
            return result;
        }


        public static int GetIntLimitsIncluded(string message,int lInf, int lSup)
        {
            int result = 0;
            int? choice = null;

            do
            {
                choice = GetIntChoice(message, 0, int.MaxValue);

                if ((choice >= lInf) && (choice <= lSup))
                {
                    break;
                }
            } while (true);
            result = (int)choice;
            return result;
        }

        public static float GetFloatLimitsIncluded(string message, float lInf, float lSup)
        {
            float result = 0;
            int? choice = null;

            do
            {
                result = GetFloatChoice(message, 0F, float.MaxValue);

                if ((choice >= lInf) && (choice <= lSup))
                {
                    break;
                }
            } while (true);
            return result;
        }
    }
}
