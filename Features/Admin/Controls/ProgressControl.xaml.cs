namespace Calculator;

public partial class ProgressControl : ContentView
{
    public ProgressControl()
    {
        InitializeComponent();
    }
    
    public static readonly BindableProperty NameProperty = BindableProperty.Create(
        nameof(Name), typeof(string), typeof(ProgressControl)
    );
    
    public static readonly BindableProperty ColorProperty = BindableProperty.Create(
        nameof(Color), typeof(Color), typeof(ProgressControl)
    );
    
    public static readonly BindableProperty ProgressProperty = BindableProperty.Create(
        nameof(Progress), typeof(int), typeof(ProgressControl)
    );
    
    public int Progress
    {
        get => (int)GetValue(ProgressProperty);
        set => SetValue(ProgressProperty, value);
    }
    
    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }
    
    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
}