namespace Calculator;

public partial class CycleChart : ContentView
{
    public CycleChart()
    {
        InitializeComponent();
    }
    
    public static readonly BindableProperty DataProperty = BindableProperty.Create(
        nameof(Data), typeof(int), typeof(CycleChart)
    );
    
    public static readonly BindableProperty DropProperty = BindableProperty.Create(
        nameof(Drop), typeof(ObservableCollection<string>), typeof(CycleChart)
    );

    public static readonly BindableProperty ColorProperty = BindableProperty.Create(
        nameof(Color), typeof(Color), typeof(CycleChart)
    );

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title), typeof(string), typeof(CycleChart)
    );
    
    public static readonly BindableProperty CountProperty = BindableProperty.Create(
        nameof(Count), typeof(int), typeof(CycleChart)
    );
    
    public static readonly BindableProperty PercentProperty = BindableProperty.Create(
        nameof(Percent), typeof(string), typeof(CycleChart)
    );

    public int Data
    {
        get => (int)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }
    
    public ObservableCollection<string> Drop
    {
        get => (ObservableCollection<string>)GetValue(DropProperty);
        set => SetValue(DropProperty, value);
    }

    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    
    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }
    
    public string Percent
    {
        get => (string)GetValue(PercentProperty);
        set => SetValue(PercentProperty, value);
    }
}