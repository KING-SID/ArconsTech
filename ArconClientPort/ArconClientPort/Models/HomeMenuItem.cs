using System;
using System.Collections.Generic;
using System.Text;

namespace ArconClientPort.Models
{
    public enum MenuItemType
    {
        Dashboard,
        About,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
