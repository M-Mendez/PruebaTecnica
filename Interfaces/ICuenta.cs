using System;
using PruebaT.Models.ViewModel;

namespace PruebaT.Interfaces
{
    public interface Icuentas
    {
        string obtenerUsuario (LoginVmodel model);
        Boolean validarEmailCumpleanio(RestaurarPass model);
        Boolean validarToken(string token);
        Boolean ActualizarPass(cambiarPassVmodel model);

    }
    
}