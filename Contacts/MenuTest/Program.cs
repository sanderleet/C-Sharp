using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace MenuTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new NavigationMenu()
            {
                Header = "Main Menu",
                MenuItems = new List<MenuItem>()
                {
                    new MenuItem(){
                        Command = "A",
                        MenuItemLine = "First Command",
                        MethodToCall = DoAnAction
                    },
                    new MenuItem()
                    {
                        Command = "B",
                        MenuItemLine = "Second Command",
                        MethodToCall = DoAnAction,
                        SubMenu = null
                    }
           
                }
            };

            mainMenu.DoMenu();
        }

        public static void DoAnAction(string param)
        {
            Console.WriteLine($"DoAnAction wa called with param; {param}!");
        }
        public static void OpenSubMenuOne(string param)
        {
            var subMenu = new NavigationMenu()
            {
                Header = "Sub Menu",
                MenuItems = new List<MenuItem>()
                {
                    new MenuItem()
                    {
                        Command = "1",
                        MenuItemLine = "First command in sub",
                        MethodToCall = DoAnAction
                    },
                }
            };

            subMenu.DoMenu();
        }

    }
}
