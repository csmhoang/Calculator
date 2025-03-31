namespace Calculator;

public partial class ItemHistoryControl : ContentView
{
    public ItemHistoryControl()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CalculationProperty = BindableProperty.Create(
        nameof(Calculation), typeof(string), typeof(ItemHistoryControl)
    );

    public static readonly BindableProperty ResultProperty = BindableProperty.Create(
        nameof(Result), typeof(string), typeof(ItemHistoryControl)
    );

    public static readonly BindableProperty CreatedAtProperty = BindableProperty.Create(
        nameof(CreatedAt), typeof(DateTime), typeof(ItemHistoryControl)
    );

    public string Calculation
    {
        get => (string)GetValue(CalculationProperty);
        set => SetValue(CalculationProperty, value);
    }

    public string Result
    {
        get => (string)GetValue(ResultProperty);
        set => SetValue(ResultProperty, value);
    }

    public DateTime CreatedAt
    {
        get => (DateTime)GetValue(CreatedAtProperty);
        set => SetValue(CreatedAtProperty, value);
    }
}