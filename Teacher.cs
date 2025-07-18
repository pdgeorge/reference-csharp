namespace CSharp
{
    partial class Teacher
    {
        private string _name;
        private string _lastName;
        public Teacher()
        {
            _name = string.Empty;
            _lastName = string.Empty;
        }

        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
    }

    partial class Teacher
    {
        public Teacher(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }
        public string GetFullName()
        {
            return _name + ' ' + _lastName;
        }
    }
}