using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theme
{
    public class DarkDialog : IDialog
    {
        public void ShowDialog()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Dark Dialog");
        }
    }
}