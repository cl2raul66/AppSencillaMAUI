namespace AppSencillaMAUI.Vistas;

public partial class PgMensaje : ContentPage
{
	public PgMensaje()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..", true);
    }
}