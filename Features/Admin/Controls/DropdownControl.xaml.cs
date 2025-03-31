namespace Calculator;

public partial class DropdownControl : ContentView
{
    public DropdownControl()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DataProperty = BindableProperty.Create(
        nameof(Data), typeof(ObservableCollection<string>), typeof(DropdownControl)
    );

    public ObservableCollection<string> Data
    {
        get => (ObservableCollection<string>)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }
}