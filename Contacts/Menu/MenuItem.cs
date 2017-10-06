using System;

namespace Menu
{
    public class MenuItem
    {
        public String MenuItemLine { get; set; }
        public string Command { get; set; }
        public MethodToCallDelegateType MethodToCall { get; set; }
        public NavigationMenu SubMenu { get; set; }

    }
}
    