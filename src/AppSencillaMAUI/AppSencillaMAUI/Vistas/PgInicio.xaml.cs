using AppSencillaMAUI.VistaModelos;

namespace AppSencillaMAUI.Vistas;

public partial class PgInicio : ContentPage
{
    public PgInicio(PgInicioVistaModelo vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}