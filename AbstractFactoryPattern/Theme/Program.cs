namespace Theme
{
    public enum AppTheme
    {
        Light=1,
        Dark=2,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IThemeAbstractFactory themeAbstractFactory = FactoryProvider.GetFactory(AppTheme.Light);
            var dialog = themeAbstractFactory.GetDialog();
            dialog.ShowDialog();


            var toolbar = themeAbstractFactory.GetToolbar();
            toolbar.ShowToolbar();


            Console.ReadLine();
        }
    }
}
