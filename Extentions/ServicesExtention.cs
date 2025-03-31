namespace Calculator;

public static class ServicesExtention
{
    /// <summary>
    ///     Đăng ký những dịch vụ trong Core
    /// </summary>
    public static MauiAppBuilder RegisterCore(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<DataContext>();
        builder.Services.AddSingleton<IAppNavigator, AppNavigator>();
        return builder;
    }

    /// <summary>
    ///     Đăng ký những dịch vụ trong Features
    /// </summary>
    public static MauiAppBuilder RegisterFeatures(this MauiAppBuilder builder)
    {
        builder.RegisterComputor();
        builder.RegisterAdmin();
        return builder;
    }

    /// <summary>
    ///     Đăng ký một số page/view không phải kế thừa từ các lớp base trong MVVM
    /// </summary>
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        var pageTypes = typeof(MauiProgram).Assembly
            .GetTypes()
            .Where(x =>
                !x.IsAbstract && x != typeof(BasePage) && x.IsAssignableTo(typeof(BasePage))
            );

        foreach (var pageType in pageTypes) builder.Services.AddTransient(pageType);

        var viewModelTypes = typeof(MauiProgram).Assembly
            .GetTypes()
            .Where(x =>
                !x.IsAbstract && x != typeof(BaseViewModel) &&
                x != typeof(NavigationAwareBaseViewModel) &&
                (
                    x.IsAssignableTo(typeof(BaseViewModel)) ||
                    x.IsAssignableTo(typeof(NavigationAwareBaseViewModel))
                )
            )
            .ToList();

        foreach (var vmType in viewModelTypes) builder.Services.AddTransient(vmType);

        return builder;
    }
}