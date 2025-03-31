using Dapper;

namespace Calculator;

public class HistoryComputorService(DataContext context) : IHistoryComputorService
{
    public async Task<IEnumerable<HistoryItemModel>> GetHistoryItemsAsync()
    {
        var sql = "SELECT * FROM HistoryItem";
        var res = await context.Connection.QueryAsync<HistoryItemModel>(sql);
        return res;
    }

    public async Task<bool> CreateHistoryItemAsync(HistoryItemModel model)
    {
        var propsKey = new List<string>();
        var paramsValue = new List<string>();
        var props = model!.GetType().GetProperties();
        var parameters = new DynamicParameters();
        foreach (var prop in props)
        {
            var propKey = prop.Name;
            propsKey.Add(propKey);
            paramsValue.Add($"@{propKey}");
            parameters.Add($"@{propKey}", prop.GetValue(model));
        }

        var sql =
            $"INSERT INTO HistoryItem ({String.Join(", ", propsKey)}) " +
            $"VALUES ({String.Join(", ", paramsValue)})";
        var res = await context.Connection.ExecuteAsync(sql, parameters);
        return res > 0;
    }
    
    public async Task<bool> DeleteHistoryItemAsync(string id)
    {
        var sql = "DELETE FROM HistoryItem WHERE Id = @id";
        var parameters = new DynamicParameters();
        parameters.Add("@id", id);
        var res = await context.Connection.ExecuteAsync(sql, parameters);
        return res > 0;
    }
}