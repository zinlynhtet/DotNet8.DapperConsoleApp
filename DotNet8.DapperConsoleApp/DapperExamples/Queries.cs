namespace DotNet8.DapperConsoleApp.DapperExamples;

public class Queries
{
    public static string GetAllQuery { get; } = "Select * from Tbl_Blogs";

    public static void ConsoleWrite(dynamic item)
    {
        Console.WriteLine(item.BlogId);
        Console.WriteLine(item.BlogTitle);
        Console.WriteLine(item.BlogAuthor);
        Console.WriteLine(item.BlogContent);
    }
}