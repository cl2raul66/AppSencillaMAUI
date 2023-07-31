using AppSencillaMAUI.Vistas;

namespace AppSencillaMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(PgMensaje), typeof(PgMensaje));
	}
}
