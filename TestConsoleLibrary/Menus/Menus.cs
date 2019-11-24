using SellIt.Database;
using SellIt.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleLibrary.Menus.Utils;

namespace TestConsoleLibrary.Menus
{
    class Menus
    {
        public static void MainMenu()
        {
            int? choice = null;
            do
            {
                choice = UtilsFunctions.GetIntChoice(UtilsMenus.MainMenuChoices(), 1, 7);

                switch(choice)
                {
                    case 1:
                        BrandsMenu();
                        break;
                    case 2:
                        CategoriesMenu();
                        break;
                    case 3:
                        CarsMenu();
                        break;
                    case 4:
                        // OrdersMenu();
                        break;
                    case 5:
                        // SellersMenu();
                        break;
                    case 6:
                        // ClientsMenu();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);
        }

        public static void BrandsMenu()
        {
            int? choice = UtilsFunctions.GetIntChoice(UtilsMenus.BrandsMenuChoices(),1,2);
            
            switch(choice)
            {
                case 1:
                    using(var db = new SellItContext())
                    {
                        foreach(var item in db.DbBrand.ToList())
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                    }
                    break;
                case 2:
                    MainMenu();
                    break;
                default:
                    break;
            }
        }

        public static void CategoriesMenu()
        {
            int? choice = UtilsFunctions.GetIntChoice(UtilsMenus.CategoriesMenuChoices(), 1, 2);

            switch (choice)
            {
                case 1:
                    using (var db = new SellItContext())
                    {
                        foreach (var item in db.DbCategory.Include(x=>x.Brand))
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                    }
                    break;
                case 2:
                    MainMenu();
                    break;
                default:
                    break;
            }
        }

        public static void CarsMenu()
        {
            int? choice = UtilsFunctions.GetIntChoice(UtilsMenus.CarsMenuChoices(), 1, 4);

            switch (choice)
            {
                case 1:
                    DisplayCarsMenu();
                    break;
                case 2:
                    //CreateCarMenu();
                    break;
                case 3:
                    //DeleteCarMenu();
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    break;
            }
        }

        public static void DisplayCarsMenu()
        {
            int? choice = UtilsFunctions.GetIntChoice(UtilsMenus.DisplayCarsMenuChoices(), 1, 7);
            string schoice = null;

            switch (choice)
            {
                case 1: // Display all cars
                    using (var db = new SellItContext())
                    {
                        foreach (var item in db.DbCar.Include(x => x.Category).Include(x => x.Category.Brand).ToList())
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        DisplayCarsMenu();
                    }
                    break;
                case 2: // Display cars by category

                    using (var db = new SellItContext())
                    {
                        // On affiche les Id de categories pour pouvoir choisir
                        foreach (var item in db.DbCategory.Include(x => x.Brand).ToList())
                        {
                            Console.WriteLine("Id : " + item.CategoryId + " : " + item.Name + " of " + item.Brand.Name);
                        }
                        Console.WriteLine("\n");

                        int? choice2 = null;
                        bool tag = false; // Condition de sortie de do
                        do
                        {
                            choice2 = UtilsFunctions.GetIntChoice("Choose Category by Id :", 1, int.MaxValue);
                            foreach (var item in db.DbCategory.ToList())
                            {
                                if (choice2 == item.CategoryId)
                                {
                                    tag = true;
                                    break;
                                }
                            }
                        } while (!tag);

                        foreach (var item in db.DbCar.Include(x => x.Category).Include(x => x.Category.Brand).Where(x => x.Category.CategoryId == choice2).ToList())
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        DisplayCarsMenu();
                    }
                    break;
                case 3: // Display Cars by brand
                    using (var db = new SellItContext())
                    {
                        foreach (var item in db.DbBrand.ToList())
                        {
                            Console.WriteLine("Id : " + item.BrandId + " " + item.Name);
                        }
                        Console.WriteLine("\n");

                        int? choice2 = null;
                        bool tag = false;
                        do
                        {
                            choice2 = UtilsFunctions.GetIntChoice("Choose Brand by Id :", 1, int.MaxValue);
                            foreach (var item in db.DbBrand.ToList())
                            {
                                if (choice2 == item.BrandId)
                                {
                                    tag = true;
                                    break;
                                }
                            }
                        } while (!tag);

                        foreach (var item in db.DbCar.Include(x => x.Category).Include(x => x.Category.Brand).Where(x => x.Category.Brand.BrandId == choice2).ToList())
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n");
                        DisplayCarsMenu();
                    }
                    break;
                case 4: // Display Cars by name
                    using (var db = new SellItContext())
                    {
                        schoice = UtilsFunctions.GetString("enter a car name");
                        foreach (var item in db.DbCar.Where(x => x.Name.Contains(schoice)).ToList()) // J'ai pas inclu brand et Category c'est plus lisible
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("\n");
                    DisplayCarsMenu();
                    break;
                case 5: // Display Cars by availability
                    using (var db = new SellItContext())
                    {
                        foreach (var item in db.DbCar.ToList()) // J'ai pas inclu brand et Category c'est plus lisible
                        {
                            if(item.Avalaible)
                            {
                                Console.WriteLine(item);
                            } 
                        }
                    }
                    Console.WriteLine("\n");
                    DisplayCarsMenu();
                    break;
                case 6: // Display Cars by year
                    using (var db = new SellItContext())
                    {
                        int? choice2 = UtilsFunctions.GetIntChoice("Enter a year", 1, int.MaxValue);

                        foreach (var item in db.DbCar.ToList()) // J'ai pas inclu brand et Category c'est plus lisible
                        {
                            if(item.Year==choice2)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine("\n");
                    DisplayCarsMenu();
                    break;
                case 7: //  Display Cars by color
                    using(var db = new SellItContext())
                    {
                        schoice = UtilsFunctions.GetString("enter a color");
                        foreach (var item in db.DbCar.Where(x => x.Color.Contains(schoice)).ToList()) // J'ai pas inclu brand et Category c'est plus lisible
                        {
                            Console.WriteLine(item);
                        }
                    }
                    Console.WriteLine("\n");
                    DisplayCarsMenu();
                    break;
                case 8:
                    CarsMenu();
                    break;
                default:
                    break;
            }
        }

        
    }
}
