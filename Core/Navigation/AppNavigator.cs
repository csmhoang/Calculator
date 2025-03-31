namespace Calculator;

public class AppNavigator : IAppNavigator
{
    private readonly IServiceProvider serviceProvider;

    public AppNavigator(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public Task GoBackAsync(bool animated = false, object? data = null)
    {
        return NavigateAsync(UriHelper.GoBackSegment, animated, data);
    }

    public Task NavigateAsync(string target, bool animated = false, object? args = null)
    {
        throw new NotImplementedException();
    }

    public Task<bool> OpenUrlAsync(string url)
    {
        throw new NotImplementedException();
    }

    public Task ShareAsync(string text, string? title = null)
    {
        throw new NotImplementedException();
    }

    public Task ShowSnackbarAsync(string message, Action? action = null, string? actionText = null)
    {
        throw new NotImplementedException();
    }
}