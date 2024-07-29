namespace FurnitureShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory carpentry = new Carpentry();
            var woodTable = carpentry.CreateTable();
            Console.WriteLine(woodTable.ToString());

            var woodChair = carpentry.CreateChair();
            Console.WriteLine(woodChair.ToString());
            Console.ReadLine();
        }
    }
}
