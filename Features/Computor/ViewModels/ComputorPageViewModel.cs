namespace Calculator;

public partial class ComputorPageViewModel(
    IAppNavigator appNavigator,
    IComputorService computorService,
    IHistoryComputorService historyComputorService)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] private Color text = Colors.Black;
    [ObservableProperty] private Color numberKey = Colors.Light;
    [ObservableProperty] private Color operatorKey = Colors.GreyLight;
    [ObservableProperty] private Color background = Colors.White;
    [ObservableProperty] private Color keyboardBackground = Colors.Light;
    [ObservableProperty] private string calculation;
    [ObservableProperty] private string result;

    private bool isTheme = true;
    private bool isComplete = true;

    [RelayCommand]
    private void Key(string key) => Calculation += key;
    
    [RelayCommand]
    private async Task Calculate()
    {
        if (!string.IsNullOrEmpty(Calculation))
        {
            Result = computorService.EvaluateExpression(Calculation)
                .ToString(CultureInfo.CurrentCulture);
            await historyComputorService.CreateHistoryItemAsync(new HistoryItemModel
            {
                Id = Guid.NewGuid().ToString(),
                Calculation = Calculation,
                Result = Result,
                CreatedAt = DateTime.Now
            });
            isComplete = !isComplete;
        }
    }

    [RelayCommand]
    private void Clear()
    {
        Calculation = string.Empty;
        Result = string.Empty;
    }

    [RelayCommand]
    private void ToggleTheme()
    {
        if (isTheme)
        {
            Text = Colors.White;
            NumberKey = Colors.Dark;
            OperatorKey = Colors.GreyDark;
            Background = Colors.Black;
            KeyboardBackground = Colors.Dark;
        }
        else
        {
            Text = Colors.Black;
            NumberKey = Colors.Light;
            OperatorKey = Colors.GreyLight;
            Background = Colors.White;
            KeyboardBackground = Colors.Light;
        }

        isTheme = !isTheme;
    }
}