namespace CSharp
{
    public interface IWriter
    {
        //returnType methodName(paramType paramName...);
        void WriteFile();
    }
    public class FileBase
    {
        public virtual void SetName()
        {
            Console.WriteLine("Setting name in the base Writer class.");
        }
    }
    public class XmlWriter : FileBase, IWriter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file from XmlWriter.");
        }
        public override void SetName()
        {
            Console.WriteLine("Setting name in XmlWriter.");
        }
    }

    public class JsonWriter : FileBase, IWriter
    {
        public void WriteFile()
        {
            Console.WriteLine("Writing file from JsonWriter.");
        }
        public override void SetName()
        {
            Console.WriteLine("Setting name in JsonWriter.");
        }
    }
}