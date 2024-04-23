namespace DotNet8.DapperConsoleApp.DapperExamples;

public class DapperService
{
    private readonly Connection _connection;

    public DapperService(Connection connection)
    {
        _connection = connection;
    }

    public void Run()
    {
        Get<BlogDataModel>();
        // Create();
        // GetById();
        Update();
    }

    private void Get<BlogDataModel>()
    {
        string query = Queries.GetAllQuery;
        IDbConnection db = new SqlConnection(_connection.ConnectionString());
        var lst = db.Query<BlogDataModel>(query).ToList();
        foreach (var item in lst)
        {
            item.ToConsole();
        }
    }

    private void GetById()
    {
        Console.Write("Enter blog Id: ");
        int id = Console.ReadLine().ToInt();

        BlogDataModel blog = new BlogDataModel()
        {
            BlogId = id
        };
        string query = Queries.GetByIdQuery;
        IDbConnection db = new SqlConnection(_connection.ConnectionString());
        BlogDataModel? item = db.Query<BlogDataModel>(query, blog).FirstOrDefault();

        item.ToConsole();
    }

    private void Create()
    {
        var title = UserInput(out var author, out var content);

        BlogDataModel blog = new BlogDataModel
        {
            BlogTitle = title,
            BlogAuthor = author,
            BlogContent = content
        };

        string query = Queries.CreateQuery;
        IDbConnection db = new SqlConnection(_connection.ConnectionString());
        int result = db.Execute(query, blog);
        string message = result > 0 ? "Creating Successful." : "Creating Failed.";
        Console.WriteLine(message);
    }

    private void Update()
    {
        Console.Write("Enter blog Id: ");
        int id = Console.ReadLine().ToInt();

        string queryGet = Queries.GetByIdQuery;
        IDbConnection db = new SqlConnection(_connection.ConnectionString());
        BlogDataModel? item = db.Query<BlogDataModel>(queryGet, new { BlogId = id }).FirstOrDefault();
        if (item is null) return;
        var title = UserInput(out var author, out var content);
        BlogDataModel blog = new BlogDataModel
        {
            BlogId = id,
            BlogTitle = title,
            BlogAuthor = author,
            BlogContent = content
        };
        string query = Queries.UpdateQuery;
        int result = db.Execute(query, blog);
        string message = result > 0 ? "Updating Successful." : "Updating Failed.";
        Console.WriteLine(message);
    }

    private void Delete()
    {
        Console.Write("Enter blog Id: ");
        int id = Console.ReadLine().ToInt();
        BlogDataModel blog = new BlogDataModel { BlogId = id };
        string queryGet = Queries.GetByIdQuery;
        IDbConnection db = new SqlConnection(_connection.ConnectionString());
        BlogDataModel? item = db.Query<BlogDataModel>(queryGet, new { BlogId = id }).FirstOrDefault();
        if (item is null) return;
        string query = Queries.DeleteQuery;
        int result = db.Execute(query, blog);
        string message = result > 0 ? "Deleting successful" : "Deleting failed";
        Console.WriteLine(message);
    }

    private static string? UserInput(out string? author, out string? content)
    {
        Console.Write("Enter blog title: ");
        string title = Console.ReadLine();

        Console.Write("Enter blog author: ");
        author = Console.ReadLine();

        Console.Write("Enter blog content: ");
        content = Console.ReadLine();
        return title;
    }
}