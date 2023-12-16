using Dapper;

namespace Enterprise.Infrastructure.SqlConnection;

public class Sql
{
    private readonly IDbConnection _dbConnection;

    public Sql(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    
    public async Task<List<T>> ListAsync<T>(string query, object queryParams)
    {
        await using var connection = _dbConnection.GetSqlConnection();
        try
        {
            var result = (await connection.QueryAsync<T>(query, queryParams)).ToList();
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}