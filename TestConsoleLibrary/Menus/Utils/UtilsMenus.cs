using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleLibrary.Menus.Utils
{
   public class UtilsMenus
    {
        public static string MainMenuChoices()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("        Main menu\n\n");
            builder.Append("1 : Brands Menu\n");
            builder.Append("2 : Categories Menu\n");
            builder.Append("3 : Cars Menu\n");
            builder.Append("4 : Orders Menu\n");
            builder.Append("5 : Sellers Menu\n");
            builder.Append("6 : Clients Menu\n");
            builder.Append("7 : Exit\n");

            return builder.ToString();
        }

        public static string BrandsMenuChoices()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("        Brands menu\n\n");
            builder.Append("1 : Display Brands\n");
            builder.Append("2 : back\n");

            return builder.ToString();
        }

        public static string CategoriesMenuChoices()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("        Categories menu\n\n");
            builder.Append("1 : Display Categories\n");
            builder.Append("2 : back\n");

            return builder.ToString();
        }

        public static string CarsMenuChoices()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("        Cars menu\n\n");
            builder.Append("1 : Display cars menu\n");
            builder.Append("2 : Create Car\n");
            builder.Append("3 : Delete Car\n");
            builder.Append("4 : back\n");

            return builder.ToString();
        }

        public static string DisplayCarsMenuChoices()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("       Display Cars menu\n\n");
            builder.Append("1 : Display all cars\n");
            builder.Append("2 : Display cars by category\n");
            builder.Append("3 : Display Cars by brand\n");
            builder.Append("4 : Display Cars by name\n");
            builder.Append("5 : Display Cars by availability\n");
            builder.Append("6 : Display Cars by year\n");
            builder.Append("7 : Display Cars by color\n");
            builder.Append("8 : back\n");

            return builder.ToString();
        }


    }
}
