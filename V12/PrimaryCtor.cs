// First introduced for records in C# 9
// You can now create primary constructors in any class and struct.
// The compiler generates public properties for primary constructor parameters
// only in record types, either record class or record struct types. Nonrecord
// classes and structs might not always want this behavior for primary
// constructor parameters.

public class PersonClass(string firstName, string lastName)
{
    public override string ToString() => $"{firstName} {lastName}";
}