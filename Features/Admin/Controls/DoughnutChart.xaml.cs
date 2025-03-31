using LiveChartsCore;

namespace Calculator;

public partial class DoughnutChart : ContentView
{
    public DoughnutChart()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DataProperty = BindableProperty.Create(
        nameof(Data), typeof(int), typeof(CycleChart)
    );

    public static readonly BindableProperty ColorAProperty = BindableProperty.Create(
        nameof(ColorA), typeof(Color), typeof(CycleChart)
    );
    
    public static readonly BindableProperty ColorBProperty = BindableProperty.Create(
        nameof(ColorB), typeof(Color), typeof(CycleChart)
    );
    
    public int Data
    {
        get => (int)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }

    public Color ColorA
    {
        get => (Color)GetValue(ColorAProperty);
        set => SetValue(ColorAProperty, value);
    }
    
    public Color ColorB
    {
        get => (Color)GetValue(ColorBProperty);
        set => SetValue(ColorBProperty, value);
    }
}