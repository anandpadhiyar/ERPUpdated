using Microsoft.Extensions.Configuration;

namespace Enterprise.Infrastructure.SqlConnection;

public class DbConnection : IDbConnection
{
    private readonly IConfiguration _configuration;

    public DbConnection(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public System.Data.SqlClient.SqlConnection GetSqlConnection()
    {
        var dbConnectionString = _configuration.GetConnectionString("Db");
        var sqlConnection = new System.Data.SqlClient.SqlConnection(dbConnectionString);
        return sqlConnection;
    }
}