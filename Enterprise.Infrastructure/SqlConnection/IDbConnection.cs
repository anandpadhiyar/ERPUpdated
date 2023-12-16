namespace Enterprise.Infrastructure.SqlConnection;

public interface IDbConnection
{
    System.Data.SqlClient.SqlConnection GetSqlConnection();
}