using System.Data;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var rectangle = new Rectangle();
            //rectangle.Draw();

            //var square = new Square();
            //square.Draw();

            //SuperClass obj=new Subclass();
            Console.WriteLine("Enter Rectangle or Square:");
            var type = Console.ReadLine();

            /*
            IShape shape = null;
            if (type.ToLower()== "rectangle")
            {
                shape = new Rectangle();
              
            }
            else if(type.ToLower() == "square")
            {
                shape = new Square();
              
            }
            else
            {
                throw new ApplicationException();
            }

            shape.Draw();
            */


            ShapeFactory factory = new ShapeFactory();
            IShape shape1 = factory.GetShape(type);
        }


        public void M1()
        {
            Console.WriteLine("Enter Rectangle or Square:");
            var type = Console.ReadLine();

            IShape shape = null;
            if (type.ToLower() == "rectangle")
            {
                shape = new Rectangle();

            }
            else if (type.ToLower() == "square")
            {
                shape = new Square();

            }
            else
            {
                throw new ApplicationException();
            }

            shape.Draw();
        }

        public void M6()
        {
            Console.WriteLine("Enter Rectangle or Square:");
            var type = Console.ReadLine();

            IShape shape = null;
            if (type.ToLower() == "rectangle")
            {
                shape = new Rectangle();

            }
            else if (type.ToLower() == "square")
            {
                shape = new Square();

            }
            else if (type.ToLower() == "circle")
            {
                shape = new Circle();

            }
            else
            {
                throw new ApplicationException();
            }

            shape.Draw();
        }
    }



    public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle: Draw() Method");
        }
    }

    public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square: Draw() Method");
        }
    }

    public interface IShape
    {
        public void Draw();

    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle: Draw() Method");
        }
    }

    public class ShapeFactory 
    {
        public IShape GetShape(string type )
        {

            //IShape shape = null;
            if (type.ToLower() == "rectangle")
            {
                return new Rectangle();

            }
            else if (type.ToLower() == "square")
            {
                return new Square();

            }
            else if (type.ToLower() == "circle")
            {
               return new Circle();

            }

            return null;
        }
    }


}
