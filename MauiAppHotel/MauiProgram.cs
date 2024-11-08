﻿using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
                    fonts.AddFont("Ubuntu-Regular.ttf", "Ubuntu");
                    fonts.AddFont("Ubuntu-Light.ttf", "UbuntuLight");
                    fonts.AddFont("Caveat-Bold.ttf", "CaveatBold");
                    fonts.AddFont("Caveat-SemiBold.ttf", "CaveatSemiBold");
                    fonts.AddFont("Caveat-Regular.ttf", "Caveat");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
