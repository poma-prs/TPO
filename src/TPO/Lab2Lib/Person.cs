namespace Lab2Lib
{
    public abstract class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }
        public int Mood { get; protected set; } = 50;

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
                return false;
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age ^ Mood;
        }
    }
}