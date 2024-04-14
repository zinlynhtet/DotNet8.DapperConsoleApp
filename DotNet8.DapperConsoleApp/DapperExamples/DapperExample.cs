namespace DotNet8.DapperConsoleApp.DapperExamples;

public class DapperExample
{
    private readonly SqlConnectionStringBuilder sqlConnectionStringBuilder;

    public DapperExample()
    {
        sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        sqlConnectionStringBuilder.DataSource = ".";
        sqlConnectionStringBuilder.InitialCatalog = "TestDb";
        sqlConnectionStringBuilder.UserID = "sa";
        sqlConnectionStringBuilder.Password = "sasa@123";
        sqlConnectionStringBuilder.TrustServerCertificate = true;
    }

    public void Run()
    {
        Get<BlogDataModel>();
    }

    private void Get<T>()
    {
        string query = Queries.GetAllQuery;
        using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
        var lst = db.Query<T>(query).ToList();
        foreach (var item in lst)
        {
            Queries.ConsoleWrite(item);
        }
    }
    //dynamic can be anything "can be the column name from the database or not". So rarely use the dynamic method.
    // private void Get()
    // {
    //     string query = Queries.GetAllQuery;
    //     using IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
    //     var lst = db.Query(query).ToList();
    //     foreach (var item in lst)
    //     {
    //         Queries.ConsoleWrite(item);
    //     }
    // }


    public void GetById()
    {
    }

    public void Create()
    {
    }

    public void Update()
    {
    }

    public void Delete()
    {
    }
}