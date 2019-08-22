using System;
using Microsoft.EntityFrameworkCore;
using PruebaT.Models;

namespace PruebaT.Models.DAL
{
    public class PruebaTcontext : DbContext
    {
        public PruebaTcontext(DbContextOptions<PruebaTcontext> options) : base(options)
        {
        }

        public DbSet<Usuario> usuario {get; set;}
        public DbSet<Empleado> empleado {get; set;}

    } 
}