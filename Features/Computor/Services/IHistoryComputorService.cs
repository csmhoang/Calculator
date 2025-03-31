namespace Calculator;

public interface IHistoryComputorService
{
    Task<IEnumerable<HistoryItemModel>> GetHistoryItemsAsync();
    Task<bool> CreateHistoryItemAsync(HistoryItemModel model);
    Task<bool> DeleteHistoryItemAsync(string id);
}