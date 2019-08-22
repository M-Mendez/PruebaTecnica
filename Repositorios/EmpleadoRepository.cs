using System;
using System.Collections.Generic;
using System.Linq;
using PruebaT.Models;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaT.Interfaces;
using PruebaT.Models.DAL;

namespace PruebaT.Repositorios
{
    public class EmpleadoRepository : IEmpleado
    {
        PruebaTcontext _context;
        public EmpleadoRepository(PruebaTcontext context)
        {
            _context = context;

        }

        public void DeleteEmpleado(int empleadoId)
        {
            Empleado emple = _context.empleado.Find(empleadoId);
            
            _context.empleado.Remove(emple);
        }

        public IEnumerable<Empleado> GetEmpleado()
        {
           return  _context.empleado.ToList();
        }

        public Empleado GetEmpleadoById(int empleadoId)
        {
           return _context.empleado.Find(empleadoId);
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            _context.empleado.Add(empleado);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateEmpleado(Empleado empleado)
        {
            _context.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }




}