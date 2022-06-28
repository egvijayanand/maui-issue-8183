using Issue8183.Controls;
using Issue8183.Renderers;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace Issue8183
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   })
                   .UseMauiCompatibility()
                   .ConfigureMauiHandlers(handlers =>
                   {
                       handlers.AddHandler(typeof(TestView), typeof(TestViewRenderer));
                   });

            return builder.Build();
        }
    }
}
