// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10

WriteTitle("Hello C# version 10");



WriteTitle("Global using directives");
// ... but where are my usings?
// See also implicit global usings
// <ImplicitUsings>enable</ImplicitUsings>



WriteTitle("File-scoped namespace declaration");
// See Utils.cs




WriteTitle("Lambda expression improvements");
// may have a natural type, where the compiler can infer a delegate type
// No longer: Action<string> print = (string s) => WriteLine(s);
var print = (string s) => WriteLine(s);
print("Automatically inferred delegate type");

// may declare a return type when the compiler can't infer it
var toInt = int? (string s) => int.TryParse(s, out var i) ? i : null;
// ... but is it better than (string s) => boolExpression ? 1 : (int?)null; ?
WriteLine($"'123' as int is {toInt("123")}");



WriteTitle("Constant interpolated strings");
const string constStr = "1337";
const string interpolatedConstStr = $"I am {constStr}";
WriteLine(interpolatedConstStr);



/*
 *
 * If time...
 *
 */



WriteTitle("Record structs");
// Records introduced in C#9 => reference types
// Can now define structs as value types => record struct MyValueTypeRecord { }
// Can also clarify ref type structs => record class MyRefTypeRecord { }



/*
 *
 * No demo
 *
 */


WriteTitle("Honorable Mentions");
WriteLine("- Improvements of structure types");
WriteLine("- Interpolated string handler");
WriteLine("- Extended property patterns");
WriteLine("- Record types can seal ToString");
WriteLine("- Assignment and declaration in same deconstruction");
WriteLine("- Improved definite assignment");
WriteLine("- Allow AsyncMethodBuilder attribute on methods");
WriteLine("- CallerArgumentExpression attribute diagnostics");
WriteLine("- Enhanced #line pragma");
