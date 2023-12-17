public class Person
{
    // Comment out ctor and observe...
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; } // See required in C#11
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
}

public class Student : Person
{
    public Student(string firstName, string lastName, int id) : base(firstName, lastName)
    {
        Id = id;
    }

    public int Id { get; set; }
    public char Gender { get; set; }
}