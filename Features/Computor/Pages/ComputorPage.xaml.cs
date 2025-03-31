namespace Calculator;

public partial class ComputorPage : BasePage
{
    public ComputorPage(ComputorPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}