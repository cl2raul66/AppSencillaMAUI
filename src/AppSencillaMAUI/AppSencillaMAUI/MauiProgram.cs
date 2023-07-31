using AppSencillaMAUI.VistaModelos;
using AppSencillaMAUI.Vistas;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AppSencillaMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<PgInicioVistaModelo>();

		builder.Services.AddSingleton<PgInicio>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
