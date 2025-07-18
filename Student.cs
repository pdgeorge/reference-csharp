namespace CSharp
{
    public class Student
    {
        private string _name;
        private string _lastName;

        public Student()
        {
            _name = string.Empty;
            _lastName = string.Empty;
        }

        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public string GetFullName()
        {
            return Name + ' ' + LastName;
        }

    }
}