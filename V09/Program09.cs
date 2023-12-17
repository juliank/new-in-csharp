using System;
using System.Linq;
using static System.Console;
using static Utils.Util;


WriteTitle("Hello C# version 9");



WriteTitle("Top-level statements - programs without Main methods");
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements
var firstArg = args.FirstOrDefault() ?? "No arguments given";
WriteLine($"First argument: {firstArg}");



WriteTitle("Init only setters");
// Examples in records...

WriteTitle("Records");
// Records provides a concise syntax for reference types that follow value
// semantics for equality. Can be mutable, they're primarily intended for
// supporting immutable data models.
// - Concise syntax for creating a reference type with immutable properties
// - Built-in behavior useful for a data-centric reference type:
//   - Value equality
//   - Concise syntax for nondestructive mutation
//   - Built-in formatting for display
// - Support for inheritance hierarchies
// => See https://sharplab.io

var p1 = new PersonRecord("John", "Doe");
WriteLine($"Hello {p1.FirstName} {p1.LastName}");
WriteLine($"Hello {p1}");
(var firstName, var lastName) = p1;
WriteLine($"firstName: {firstName}");
WriteLine($"lastName: {lastName}");

var p2 = p1 with { FirstName = "John" };
//p2.FirstName = "Jane"; // Error: init-only
WriteLine($"object.ReferenceEquals(p1, p2): {object.ReferenceEquals(p1, p2)}");
WriteLine($"object.Equals(p1, p2): {object.Equals(p1, p2)}");
WriteLine($"p1: Hello {p1.FirstName} {p1.LastName}");
WriteLine($"p2: Hello {p2.FirstName} {p2.LastName}");

// Beware: In the case of a reference-type member, only the reference to a
//         member instance is copied when an operand is copied.
// p2.MiddleNames!.Add("Billy");
// WriteLine($"p1.MiddleNames: {string.Join(", ", p1.MiddleNames!)}");



WriteTitle("Pattern matching enhancements");

// Relational patterns: any of the relational operators <, >, <=, or >=
var temperature = -3;
var feeling = temperature switch
{
    >= 100 => "boiling",
    > 56 => "record temperature",
    > 30 => "really hot",
    > 20 => "comfortable",
    > 10 => "ok",
    > 0 => "chilly",
    _ => "too cold"
};
WriteLine($"It is {feeling} outside");

// Logical patterns: the not, and, and or pattern combinators
var date = DateTime.Now.AddMonths(6);
var season = date.Month switch
{
    12 or < 3 => "winter",
    >= 3 and < 6 => "spring",
    6 or 7 or 8 => "summer",
    > 8 => "autumn"
};
WriteLine($"On {date:d} it is {season}");



/*
 *
 * If time...
 *
 */



WriteTitle("Target-typed new expressions");
WriteTitle("Lambda discard parameters");



/*
 *
 * No demo
 *
 */



WriteTitle("Honorable Mentions");
WriteLine("- static anonymous functions");
WriteLine("- Target-typed conditional expressions");
WriteLine("- Covariant return types");
WriteLine("- Extension GetEnumerator support for foreach loops");
WriteLine("- Attributes on local functions");



WriteTitle("Performance and interop");
WriteLine("- Native sized integers");
WriteLine("- Function pointers");
WriteLine("- Suppress emitting localsinit flag");
WriteLine("- Module initializers");
WriteLine("- New features for partial methods");

