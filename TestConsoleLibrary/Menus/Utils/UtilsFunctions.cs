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
        public static Brand CreateBrandByConsole()
        {
            Brand result = null;

            Console.WriteLine("Création d'une marque :\n");

            using (var db = new SellItContext())
            {
                // On vérifie que le nom n'est pas utilisé par une autre marque:
                bool tag = false; // sortie de do si tag (tag==true)
                string choice = null;
                do
                {
                    choice = GetString("Entrer le nom de la marque :");
                    int count = 0;
                    foreach (var item in db.DbBrand.ToList())
                    {
                        if (choice == item.Name)
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

                result.Name = choice;
                result.Description = GetString("\nEntrer une déscription de la marque :");
            }

            return result;
        }

        public static List<Car> CarSortedByYear()
        {
            List<Car> result = null;
            using (var db = new SellItContext())
            {
                result = db.DbCar.OrderBy(x=>x.Year).ToList();
            }

            return result;
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
    }
}
