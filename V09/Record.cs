// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
// You use the record modifier to define a reference type that provides built-in
// functionality for encapsulating data.
// C# 10 allows the record class syntax as a synonym to clarify a reference
// type, and record struct to define a value type with similar functionality.
using System.Collections.Generic;

public record PersonRecord(string FirstName, string LastName); //, List<string>? MiddleNames = null);

// Roughly the same as as:
// public record PersonRecord
// {
//     public PersonRecord(string firstName, string lastName)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//     }
//     public string FirstName { get; init; }
//     public string LastName { get; init; }
// }

public record MutablePersonRecord
{
    public MutablePersonRecord(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}