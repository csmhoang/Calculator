namespace Calculator;

public class HistoryItemModel
{
    public string Id { get; set; } = null!;
    public string Calculation { get; set; } = null!;
    public string Result { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}