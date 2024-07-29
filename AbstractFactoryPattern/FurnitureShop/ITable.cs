using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureShop
{
    public interface ITable
    {
    }
    public interface IChair
    {

    }
    public class MetalTable : ITable
    {
        public override string ToString()
        {
            return "i am MetalTable";
        }
    }
    public class WoodTable : ITable
    {
        public override string ToString()
        {
            return "i am WoodTable";
        }
    }
    public class MetalChair : IChair
    {
        public override string ToString()
        {
            return "i am MetalChair";
        }
    }
    public class WoodChair : IChair
    {
        public override string ToString()
        {
            return "i am WoodChair";
        }
    }
    public interface IFactory
    {
        ITable CreateTable();
        IChair CreateChair();
    }
    public class Carpentry:IFactory
    {
        public ITable CreateTable()
        {
           return new WoodTable();
        }

        public IChair CreateChair()
        {
            return new WoodChair();
        }
    }

    public class MetalShop:IFactory
    {
        public ITable CreateTable()
        {
            return new MetalTable();
        }

        public IChair CreateChair()
        {
           return new MetalChair();
        }
    }
}
