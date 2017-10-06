using System;
using System.Collections.Generic;
using Menu;

namespace MenuDefinition
{
    public static class AppMenu
    {
        public static NavigationMenu MainMenu { get; set; } = new NavigationMenu()
        {
            Header = "Main menu",
            MenuItems = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Command = "P",
                    MenuItemLine = "Persons",
                    SubMenu = new NavigationMenu()
                    {
                        Header = "Persons Menu",
                        MenuItems = new List<MenuItem>(){
                            new MenuItem()
                            {
                                Command = "L",
                                MenuItemLine = "List",
                                SubMenu = null,
                            },
                            new MenuItem()
                            {
                                Command = "C",
                                MenuItemLine = "Create",
                                SubMenu = null,
                            },
                            new MenuItem()
                            {
                                Command = "U",
                                MenuItemLine = "Update",
                                SubMenu = null,
                            },
                            new MenuItem()
                            {
                                Command = "D",
                                MenuItemLine = "Delete",
                                SubMenu = null,
                            },
                        }
                    },
                },
                new MenuItem()
                {
                    Command = "C",
                    MenuItemLine = "ContactTypes",
                    SubMenu = new NavigationMenu()
                    {
                        Header = "ContactTypes Menu",
                        MenuItems = new List<MenuItem>()
                        {
                            new MenuItem()
                            {
                                Command = "L",
                                MenuItemLine = "List",
                                SubMenu = null,
                            },
                            new MenuItem()
                            {
                                Command = "C",
                                MenuItemLine = "Create",
                                SubMenu = null,
                            },
                            new MenuItem()
                            {
                                Command = "U",
                                MenuItemLine = "Update",
                                SubMenu = null,
                            },
                            new MenuItem()
                            {
                                Command = "D",
                                MenuItemLine = "Delete",
                                SubMenu = null,
                            },
                        }
                    },
                },
                new MenuItem()
                {
                    Command = "S",
                    MenuItemLine = "Search",
                    SubMenu = null,
                },
            }
        };
    }
}
