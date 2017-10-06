using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class NavigationMenu
    {
        public string Header { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        // draw out the menu, wait for commands
        public void DoMenu()
        {
            // repeat as long as you get correct command or X
            var command = "";
            do
            {
                PrintMenu(MenuItems);

                command = Console.ReadLine().ToUpper();
                if (command != "X")
                {
                    var menuItemDone = false;
                    foreach (var menuItem in MenuItems)
                    {
                        if (menuItem.Command.ToUpper() == command)
                        {
                            if (menuItem.SubMenu == null)
                            {
                                // execute delegate method
                                menuItem.MethodToCall?.Invoke(menuItem.MenuItemLine);
                            }
                            else
                            {
                                menuItem.SubMenu.DoMenu();
                            }
                            menuItemDone = true;
                            break;
                        }
                    }
                    if (!menuItemDone)
                    {
                        Console.WriteLine("Unknown command!");
                    }

                    Console.WriteLine();
                }
            } while (command != "X");
        }

        private void PrintMenu(List<MenuItem> menuItems)
        {
            Console.WriteLine(Header);
            Console.WriteLine("---");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine($"{menuItem.Command} => {menuItem.MenuItemLine}");
            }
            Console.WriteLine("X => Return");
            Console.Write(">");
        }
    }
}
