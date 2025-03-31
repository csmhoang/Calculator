namespace Calculator;

public partial class HistoryCalculatorPage : BasePage
{
    public HistoryCalculatorPage(HistoryComputorViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}