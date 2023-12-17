// You can add the required modifier to properties and fields to enforce
// constructors and callers to initialize those values.

public class Person
{
    public string FirstName { get; init; }
    public required string LastName { get; init; }

    // required members => try commenting out the ctor and observe
    public Person(string firstName)
    {
        FirstName = firstName;
    }

    public override string ToString()
    {
        return NameFormatter.FormatName(FirstName, LastName);
    }
}

// The file modifier restricts a top-level type's scope and visibility to the
// file in which it's declared. The file modifier will generally be applied to
// types written by a source generator. File-local types provide source
// generators with a convenient way to avoid name collisions among generated
// types.
file static class NameFormatter
{
    public static string FormatName(string firstName, string lastName) => $"{firstName} {lastName}";
}