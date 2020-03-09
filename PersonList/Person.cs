namespace PersonList
{
    class Person
    {
        string _name;
        int _age;
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}