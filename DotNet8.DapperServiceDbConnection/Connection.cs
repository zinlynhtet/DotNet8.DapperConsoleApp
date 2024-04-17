using System.Data.SqlClient;
namespace DotNet8.DapperServiceDbConnection;

public class Connection
{
    public string DapperExample()
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        sqlConnectionStringBuilder.DataSource = ".";
        sqlConnectionStringBuilder.InitialCatalog = "TestDb";
        sqlConnectionStringBuilder.UserID = "sa";
        sqlConnectionStringBuilder.Password = "sasa@123";
        sqlConnectionStringBuilder.TrustServerCertificate = true;
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
