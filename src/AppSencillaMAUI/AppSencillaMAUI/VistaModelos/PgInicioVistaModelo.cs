using AppSencillaMAUI.Vistas;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSencillaMAUI.VistaModelos;

public partial class PgInicioVistaModelo : ObservableObject
{
    [RelayCommand]
    async Task VerMensaje()
    {
        await Shell.Current.GoToAsync(nameof(PgMensaje), true);
    }
}
