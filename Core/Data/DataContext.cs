using System.Data;
using Microsoft.Data.SqlClient;

namespace Calculator;

public class DataContext
{
    public IDbConnection Connection { get; } = new SqlConnection(
        @"Data Source=MSI;Initial Catalog=Calculator;Integrated Security=True;Trust Server Certificate=True");
}