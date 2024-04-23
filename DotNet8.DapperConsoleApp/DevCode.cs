namespace DotNet8.DapperConsoleApp;

public static class DevCode
{
    public static void ToConsole(this object item)
    {
        dynamic dynamicItem = item;

        if (dynamicItem is not null)
        {
            Console.WriteLine($"BlogId: {dynamicItem.BlogId}");
            Console.WriteLine($"BlogTitle: {dynamicItem.BlogTitle}");
            Console.WriteLine($"BlogAuthor: {dynamicItem.BlogAuthor}");
            Console.WriteLine($"BlogContent: {dynamicItem.BlogContent}");
        }
        else
        {
            Console.WriteLine("Object is null.");
        }
    }

    public static string ToJson(this object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

    public static int ToInt(this string str)
    {
        return Convert.ToInt32(str);
    }
}