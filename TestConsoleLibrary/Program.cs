using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellIt.Database;
using SellIt.Entities;
using TestConsoleLibrary.Menus;
using TestConsoleLibrary.Menus.Utils;

namespace TestConsoleLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List<string> liste = UtilsFunctions.getCarTypeList();
            //foreach(var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            Menus.Menus.MainMenu();
            Console.ReadLine();
        }
    }
}

