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
    }

    public void Get()
    {
    }

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