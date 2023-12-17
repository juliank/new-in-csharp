using static System.Console;
using static Utils.Util;
using System.IO;
using System.Net;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        WriteTitle("Hello C# version 8"); // (and older...)



        WriteTitle("Nullable reference types");
        // See csproj <Nullable>enable</Nullable>
        var p = new Person("John", "Doe");
        // p.FirstName = null!;
        WriteLine($"Length of {p.FirstName} {p.LastName}'s names:");
        WriteLine($"- First name: {p.FirstName.Length}");
        WriteLine($"- Middle name: {p.MiddleName?.Length}");
        WriteLine($"- Last name: {p.LastName.Length}");



        WriteTitle("Default interface methods");
        var thing = new Thing("Some thing", 2023);
        WriteLine($"{thing.Name} is produced in {thing.ProductionYear}");
        // WriteLine($"{thing.Name} is {thing.GetAge()} years old");



        WriteTitle("Indices and ranges");
        int[] ints = { 1, 2, 3, 4, 5 };
        var first = ints[0];
        var last = ints[^1]; // ^0 yields IndexOutOrRange
        Range middle = 1..^1; // NB: End index in range is *excluding*
        WriteLine($"first: {first}");
        WriteLine($"last: {last}");
        WriteLine($"middle: {string.Join(',', ints[middle])}");



        /*
         *
         * If time... (Yes, probably...)
         *
         */



        WriteTitle("Pattern matching enhancements");

        // - Switch expressions
        var i = 1;
        var str = i switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            _ => "Unknown"
        };
        WriteLine($"{i} => {str}");

        // - Property patterns
        Person person = new Student("Jim", "Joker", 42) { Gender = 'M' };
        var label = person switch
        {
            Student { Gender: 'M' } s => $"Mr. {person.LastName} ({s.Id})",
            Student { Gender: 'F' } s => $"Ms. {person.LastName} ({s.Id})",
            _ => $"{person.FirstName} {person.LastName}",
        };
        WriteLine(label);

        // - Tuple patterns
        // - Positional patterns



        WriteTitle("Using declarations");
        // Save indentation - old syntax
        // using (var responseStream = httpResponse.GetResponseStream())
        // {
        //     using (readStream = new StreamReader(responseStream))
        //     {
        //         // Read stuff
        //     }
        // }
        // new syntax
        // HttpWebResponse httpResponse = null!;
        // using var responseStream = httpResponse.GetResponseStream();
        // using var readStream = new StreamReader(responseStream);


        /*
         *
         * No demo
         *
         */



        WriteTitle("Honorable Mentions");
        WriteLine("- Readonly members");
        WriteLine("- Static local functions");
        WriteLine("- Disposable ref structs");
        WriteLine("- Asynchronous streams");
        WriteLine("- Null-coalescing assignment"); // ??=
        WriteLine("- Unmanaged constructed types");
        WriteLine("- Stackalloc in nested expressions");
        WriteLine("- Enhancement of interpolated verbatim strings");
    }
}
