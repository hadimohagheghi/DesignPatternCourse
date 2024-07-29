using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theme
{
    public class DarkToolbar : IToolbar
    {
        public void ShowToolbar()
        {
           Console.ForegroundColor= ConsoleColor.DarkBlue;
           Console.WriteLine("Dark Toolbar");
        }
    }
}