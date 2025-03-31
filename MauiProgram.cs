using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Converters;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace Calculator;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseSkiaSharp()
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Cabin-Regular.ttf", "CabinFont");
                fonts.AddFont("Baloo2-Bold.ttf", "BalooFont");
            })
            // Ứng dụng sẽ tự động lưu trữ thông tin phiên bản mỗi khi ứng dụng được khởi động
            .ConfigureEssentials(essentials => { essentials.UseVersionTracking(); })
            .RegisterCore()
            .RegisterFeatures()
            .RegisterPages();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}