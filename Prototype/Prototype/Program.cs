using System;
using Newtonsoft.Json;


namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var largeObject = new LargeObject()
            {
                Id = "1",
                Title = "Test",
                InnerClass = new InnerClass() { Text = "test description" }
            };

            var shallowCopy = largeObject.ShallowCopy();

            var deepCopy = largeObject.DeepCopy();

            shallowCopy.InnerClass.Text = "after change shallow copy";

            deepCopy.InnerClass.Text = "after Change Deep Copy";

            Console.ReadLine();
        }
    }
    /// <summary>
    /// IPrototype
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICloneable<out T> where T : class
    {
        T ShallowCopy();
        T DeepCopy();
    }

    public class LargeObject : ICloneable<LargeObject>
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public InnerClass InnerClass { get; set; }
        public LargeObject ShallowCopy()
        {
            return (LargeObject)MemberwiseClone();
        }

        public LargeObject DeepCopy()
        {
            var inJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<LargeObject>(inJson);
        }
    }

    public class InnerClass
    {
        public string Text { get; set; }
    }
}