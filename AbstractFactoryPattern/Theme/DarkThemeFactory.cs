using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theme
{
    public class DarkThemeFactory : IThemeAbstractFactory
    {
        public IDialog GetDialog()
        {
            IDialog darkDialog = new DarkDialog();
            return darkDialog;
            
        }

        public IToolbar GetToolbar()
        {
            IToolbar darkToolbar = new DarkToolbar();
            return darkToolbar;
        }
    }
}