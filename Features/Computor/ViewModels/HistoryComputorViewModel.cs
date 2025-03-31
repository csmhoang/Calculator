namespace Calculator;

public partial class HistoryComputorViewModel(
    IAppNavigator appNavigator,
    IHistoryComputorService historyComputorService) 
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] public ObservableCollection<HistoryItemModel> histories;

    public async Task LoadHistoryAsync()
    {
        var datas = await historyComputorService.GetHistoryItemsAsync();
        Histories = new(datas);
    }

    public override async Task OnAppearingAsync()
    {
        await LoadHistoryAsync();
        await base.OnAppearingAsync();
    }
}