namespace Calculator;

public static class ComputorExtensions
{
    public static MauiAppBuilder RegisterComputor(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IComputorService, ComputorService>();
        builder.Services.AddSingleton<IHistoryComputorService, HistoryComputorService>();
        return builder;
    }
}