namespace Utils;

public static class Util
{
    public static void WriteTitle(string title)
    {
        Console.WriteLine($"\r\n\r\n{title}\r\n{new string('-', title.Length)}");
    }
}
