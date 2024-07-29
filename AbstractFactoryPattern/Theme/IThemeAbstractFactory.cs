using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theme
{
    public interface IThemeAbstractFactory
    {
        IDialog GetDialog();
        IToolbar GetToolbar();
    }
}