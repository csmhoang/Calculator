namespace Calculator;

public partial class AdminPage : BasePage
{
    public AdminPage(AdminViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}