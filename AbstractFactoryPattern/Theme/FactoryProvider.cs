using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theme
{
    public class FactoryProvider
    {
        /*
        public static IThemeAbstractFactory GetFactory(AppTheme theme)
        {
            IThemeAbstractFactory factory = null;

            switch (theme)
            {
                case AppTheme.Light:
                    factory = new LightThemeFactory();
                    break;
                case AppTheme.Dark:
                    factory = new DarkThemeFactory();
                    break;

            }

            return factory;
        }

        */

        public static IThemeAbstractFactory GetFactory(AppTheme theme) =>
            theme switch
            {
                AppTheme.Light => new LightThemeFactory(),
                AppTheme.Dark => new DarkThemeFactory(),
                _ => throw new ArgumentException($"Unsupported theme: {theme}")
            };
    }
}