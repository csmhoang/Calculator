namespace Calculator;

public partial class StackedAreaChart : ContentView
{
    public StackedAreaChart()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DataProperty = BindableProperty.Create(
        nameof(Data), typeof(ObservableCollection<AreaDataModel>), typeof(CycleChart)
    );

    public ObservableCollection<AreaDataModel> Data
    {
        get => (ObservableCollection<AreaDataModel>)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }
}