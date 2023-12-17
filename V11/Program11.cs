// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11

WriteTitle("Hello C# version 11");



WriteTitle("Raw string literals");
// starts with at least three double-quote (""") (...) ends with the same number
// newlines at start and end aren't included
var oldLiteral = @"
asdf
";
WriteLine($"oldLiteral:\r\n{oldLiteral}");

(var x, var y) = (1, 2);
var stringLiteral = $$"""
    This is the start of a very long string.
    I can span multiple lines.
    I can contain "double quotes" and ""double quotes X2""
        Indentation is supported
    And values (point: {{{x}}, {{y}}}) can be interpolated
""";
WriteLine($"stringLiteral:\r\n{stringLiteral}");



WriteTitle("Required members");
// See also init-only setters (C#9)
// You can add the required modifier to properties and fields to enforce
// constructors and callers to initialize those values.
var person = new Person("John") { LastName = "Doe" };
WriteLine($"Hello {person}");


WriteTitle("List patterns");
int[] numbers = { 1, 2, 3 };
WriteLine("1, 2, 3 is");
WriteLine($"-            [1, 2, 3]: {numbers is [1, 2, 3]}");
WriteLine($"-            [1, 2, 4]: {numbers is [1, 2, 4]}");
WriteLine($"-         [1, 2, 3, 4]: {numbers is [1, 2, 3, 4]}");
WriteLine($"- [0 or 1, <= 2, >= 3]: {numbers is [0 or 1, <= 2, >= 3]}");
WriteLine($"-              [1, ..]: {numbers is [1, ..]}");
WriteLine($"-              [.., 3]: {numbers is [.., 3]}");
WriteLine($"-            [_, 2, _]: {numbers is [_, 2, _]}");

var knock = "Knock, knock";
var knockMatch = knock is ['K' or 'k', .. var s, 'K' or 'k']
    ? $"[{knock}] begins and ends with a K, the middle is: {s}"
    : $"[{knock}] doesn't match]";
WriteLine(knockMatch);



/*
 *
 * If time...
 *
 */


WriteTitle("File local types");
// The file modifier restricts a top-level type's scope and visibility to the
// file in which it's declared.
// NameFormatter.FormatName("John", "Doe"); // The name 'NameFormatter' does not exist in the current context (CS0103)



/*
 *
 * No demo
 *
 */


WriteTitle("Honorable Mentions");
WriteLine("- Generic attributes");
WriteLine("- Generic math support");
// https://learn.microsoft.com/en-us/dotnet/standard/generics/math
// Instead of overload for each type
// - static int Add(int first, int second)
// - static float Add(float first, float second)
// - ...
// you can now do the following based on INumber<TSelf>
// static T Add<T>(T left, T right) where T : INumber<T> => left + right;
WriteLine("- Newlines in string interpolations");
WriteLine("- Auto-default struct");
// var defaultOfStruct = default(StructType) // all fields of a struct type are initialized to their default value
WriteLine("Pattern match Span<char> or ReadOnlySpan<char> on a constant string");
WriteLine("Extended nameof scope");
WriteLine("UTF-8 string literals");
// ReadOnlySpan<byte> utf8 = "I'm UTF-8 string"u8;
WriteLine("ref fields and ref scoped variables");

// And quite some more...
// - Numeric IntPtr and UIntPtr
// - Improved method group conversion to delegate