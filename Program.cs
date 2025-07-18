using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Interfaces();
            Console.ReadKey();
        }
        public static void Interfaces()
        {
            XmlWriter xmlwriter = new XmlWriter();
            xmlwriter.SetName();
            xmlwriter.WriteFile();
            JsonWriter jsonwriter = new JsonWriter();
            jsonwriter.SetName();
            jsonwriter.WriteFile();
            FileBase filebase = new FileBase();
            filebase.SetName();
        }
        public static void Classes()
        {
            Student student = new Student();
            student.Name = "David";
            Console.WriteLine($"Student: {student.GetFullName()}");
            Student student10 = new Student("John", "Smith");
            Console.WriteLine($"Student10: {student10.GetFullName()}");
            Teacher teacher = new Teacher();
            teacher.LastName = "Doe";
            Console.WriteLine($"Teacher: {teacher.GetFullName()}");
            Teacher teacher10 = new Teacher("Teacher", "Second");
            Console.WriteLine($"Teacher10: {teacher10.GetFullName()}");
            Teacher teacher20 = new("Teacher20", "Lastname"); // Trying the suggested method of instantiation
            Console.WriteLine($"{teacher20.Name} {teacher20.LastName}");
        }
        public static void Extentions()
        {
            // Takes Extending the string class. Effectively we have given the string class a new function.
            // This is done using the "this" keyword.
            string word = "footballs"
                            .FirstLetterUpperCase();

            Console.WriteLine(word);
        }
        public static void Anon()
        {
            var myAnonObj = new { Name = "John", Age = 32 };
            int? number = null; // Nullable. Can be nulled. Null check occurs later.
            int another = 200;
            var word = "Example";
            var money = 987.65;
            Console.WriteLine($"AnonObj name is {myAnonObj.Name}, age is {myAnonObj.Age}");
            Console.WriteLine($"Number is {number}, word is {word}, money is {money}.");
            if (number.HasValue)
            {
                Console.WriteLine($"Number is {number}.");
            }
            else
            {
                Console.WriteLine($"Another is {another}");
            }
        }
        // Example
        public struct ExTime
        {
            private int _hours, _minutes, _seconds;

            public ExTime(int hours, int minutes, int seconds)
            {
                _hours = hours;
                _minutes = minutes;
                _seconds = seconds;
            }

            public void PrintTime()
            {
                Console.WriteLine($"Hours: {_hours}, Minutes: {_minutes}, Seconds: {_seconds}");
            }
        }
        public static void Structs()
        {
            ExTime extime = new ExTime(3, 30, 25);
            extime.PrintTime();
        }
    }
}