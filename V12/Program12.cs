// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
WriteTitle("Hello C# version 12");



WriteTitle("Primary constructors for any class and struct");
// See first primary constructors for records in C#9
WriteLine($"Hello {new PersonClass("John", "Doe")}");

WriteTitle("Collection expressions");
// initialization with []
int[] intArray = [1, 2, 3];
List<int> intList = [7, 8, 9];
WriteLine($"intArray: {string.Join(", ", intArray)}");
WriteLine($"intList: {string.Join(", ", intList)}");
Dictionary<int, string> intDict = []; // Better than new()? :shrug:
IEnumerable<int> intEnum = [];
WriteLine($"intEnum type: {intEnum.GetType().Name}");
WriteLine($"intArray type: {intArray.GetType().Name}");
WriteLine($"intList type: {intList.GetType().Name}");

// Concatenation with the spread operator (..)
IEnumerable<int> concatenated = [.. intArray, 4, 5, 6, .. intList];
WriteLine($"concatenated: {string.Join(", ", concatenated)}");



WriteTitle("Experimental attribute");

[Experimental("NN1337")]
void AnExperimentalMethod()
{
    WriteLine("I am experimental!");
}
#pragma warning disable NN1337 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
AnExperimentalMethod();
#pragma warning restore NN1337 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.



/*
 *
 * If time...
 *
 */



WriteTitle("Default lambda parameters");

var IncrementValue = (int val, int inc = 1) => val + inc;
WriteLine($"IncrementValue(2): {IncrementValue(2)}");
WriteLine($"IncrementValue(2, 5): {IncrementValue(2, 5)}");



WriteTitle("Alias any type");
// Before - only named types: using Person = PersonClass;
// Now using can reference any type:
// using Point = (int x, int y);
// using IntArray = int[];



/*
 *
 * No demo
 *
 */



WriteTitle("Honorable Mentions");
WriteLine("- ref readonly parameters");
WriteLine("- Inline arrays");
WriteLine("- Interceptors");
