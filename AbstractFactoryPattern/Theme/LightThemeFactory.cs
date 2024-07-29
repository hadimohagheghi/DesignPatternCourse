using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theme
{
    public class LightThemeFactory : IThemeAbstractFactory
    {

        public IToolbar GetToolbar()
        {
            IToolbar lightToolbar = new LightToolbar();
            return lightToolbar;
        }

        public IDialog GetDialog()
        {
            IDialog lightDialog = new LightDialog();
            return lightDialog;
        }
    }
}