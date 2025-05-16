using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace Question
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                 .ConfigureMauiHandlers(_ =>
                 {
                     ButtonHandler.Mapper.AppendToMapping(
                         nameof(View.BackgroundColor),
                         (handler, View) => handler.UpdateValue(nameof(IView.Background)));
                 })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
