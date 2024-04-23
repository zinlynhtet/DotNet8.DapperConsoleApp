namespace DotNet8.DapperConsoleApp.DapperExamples;

public class Queries
{
    public static string GetAllQuery { get; } = "Select * from Tbl_Blogs";
    public static string GetByIdQuery { get; } = @"Select * from Tbl_Blogs where BlogId = @BlogId";
    public static string CreateQuery { get; } = @"INSERT INTO [dbo].[Tbl_Blogs]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
     VALUES
           (@BlogTitle,
		   @BlogAuthor,
		   @BlogContent)";

    public static string UpdateQuery { get; } = @"UPDATE [dbo].[Tbl_Blogs]
     SET [BlogTitle] = @BlogTitle
      ,[BlogAuthor] = @BlogAuthor
      ,[BlogContent] = @BlogContent
     WHERE BlogId = @BlogId";
    public static string DeleteQuery { get; } = @"DELETE FROM [dbo].[Tbl_Blogs]
    WHERE BlogId = @BlogId";

    public static void ConsoleWrite(dynamic item)
    {
        Console.WriteLine(item.BlogId);
        Console.WriteLine(item.BlogTitle);
        Console.WriteLine(item.BlogAuthor);
        Console.WriteLine(item.BlogContent);
    }
}