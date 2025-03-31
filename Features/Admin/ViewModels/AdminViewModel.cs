namespace Calculator;

public partial class AdminViewModel(IAppNavigator appNavigator)
    : NavigationAwareBaseViewModel(appNavigator)
{
    [ObservableProperty] public ObservableCollection<StackedColumnModel> stackedColumnSeries;
    [ObservableProperty] public ObservableCollection<AreaDataModel> stackedAreaSeries;
    [ObservableProperty] public ObservableCollection<string> comboboxWeeks;
    [ObservableProperty] public ObservableCollection<string> comboboxMonths;
    [ObservableProperty] public ObservableCollection<string> comboboxOptions;
    [ObservableProperty] public ObservableCollection<MenuItemModel> menuItems;

    public override async Task OnAppearingAsync()
    {
        StackedColumnSeries =
        [
            new StackedColumnModel { Day = "Mon", Applications = 0.3, Rejected = 0.4, Shortlisted = 0.2 },
            new StackedColumnModel { Day = "Tue", Applications = 0.1, Rejected = 0.2, Shortlisted = 0.2 },
            new StackedColumnModel { Day = "Wed", Applications = 0.3, Rejected = 0.3, Shortlisted = 0.3 },
            new StackedColumnModel { Day = "Thu", Applications = 0.5, Rejected = 0.1, Shortlisted = 0.3 },
            new StackedColumnModel { Day = "Fri", Applications = 0.2, Rejected = 0.2, Shortlisted = 0.1 },
            new StackedColumnModel { Day = "Sat", Applications = 0.3, Rejected = 0.2, Shortlisted = 0.2 },
            new StackedColumnModel { Day = "Sun", Applications = 0.1, Rejected = 0.2, Shortlisted = 0.4 },
        ];

        StackedAreaSeries =
        [
            new AreaDataModel { Time = "8:00 am", Percentage = 0.45 },
            new AreaDataModel { Time = "10:00 am", Percentage = 0.7 },
            new AreaDataModel { Time = "12:00 pm", Percentage = 0.73 },
            new AreaDataModel { Time = "2:00 pm", Percentage = 0.76 },
            new AreaDataModel { Time = "4:00 pm", Percentage = 0.9 },
            new AreaDataModel { Time = "6:00 pm", Percentage = 0.72 },
            new AreaDataModel { Time = "8:00 pm", Percentage = 0.6 },
            new AreaDataModel { Time = "10:00 pm", Percentage = 0.8 }
        ];

        ComboboxWeeks =
        [
            "Tuần 1",
            "Tuần 2",
            "Tuần 3",
            "Tuần 4",
            "Tuần 5",
            "Tuần 6",
            "Tuần 7",
            "Tuần 8",
            "Tuần 9",
            "Tuần 10",
        ];

        ComboboxMonths =
        [
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12",
        ];

        ComboboxOptions =
        [
            "Theo tháng",
            "Theo năm"
        ];

        MenuItems =
        [
            new MenuItemModel { Icon = "dashboard.png", Name = "Dashboard" },
            new MenuItemModel { Icon = "job.png", Name = "Jobs" },
            new MenuItemModel { Icon = "schedule.png", Name = "Schedule" },
            new MenuItemModel { Icon = "file.png", Name = "Documents" },
            new MenuItemModel { Icon = "stats.png", Name = "Statistics" },
            new MenuItemModel { Icon = "community.png", Name = "Community" },
            new MenuItemModel { Icon = "chat.png", Name = "Messages" },
            new MenuItemModel { Icon = "log_out.png", Name = "Logout" }
        ];

        await base.OnAppearingAsync();
    }

    [RelayCommand]
    private void SelectMenuItem(string item) =>
        Shell.Current.DisplayAlert("Thông báo", $"Bạn đã click vào {item}!", "Yes");
}