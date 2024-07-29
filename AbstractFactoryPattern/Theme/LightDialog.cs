namespace Theme
{
    public class LightDialog : IDialog
    {
        public void ShowDialog()
        {
            var originalColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Light Dialog");
            }
            finally
            {
                Console.ForegroundColor = originalColor;
            }
        }
    }
}



