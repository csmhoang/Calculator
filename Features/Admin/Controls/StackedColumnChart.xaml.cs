using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;

namespace Calculator;

public partial class StackedColumnChart : ContentView
{
    public StackedColumnChart()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DataProperty = BindableProperty.Create(
        nameof(Data), typeof(ObservableCollection<StackedColumnModel>), typeof(StackedColumnChart)
    );
    
    public ObservableCollection<StackedColumnModel> Data
    {
        get => (ObservableCollection<StackedColumnModel>)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }
}