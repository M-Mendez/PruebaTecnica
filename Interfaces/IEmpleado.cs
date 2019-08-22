using System;
using System.Collections.Generic;
using PruebaT.Models;

namespace PruebaT.Interfaces
{
    public interface IEmpleado
    {

        IEnumerable<Empleado> GetEmpleado();
        Empleado GetEmpleadoById(int empleadoId);
        void InsertarEmpleado(Empleado empleado);
        void DeleteEmpleado(int empleadoId);
        void UpdateEmpleado(Empleado empleado);
        void Save();
        
    }
    
}