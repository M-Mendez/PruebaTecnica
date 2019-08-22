using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaT.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        
        [Required]
        public Int64 DPI { get; set; }
        [Required]

        public string NombreCompleto { get; set; }
       
        [Required]
        public int cantidadHijos { get; set; }
       
        [Required]
        public Decimal SALARIOBASE { get; set; }
        
        public Decimal BonoDecreto { get; set; }
        
        public Decimal Iggs { get; set; }
        public Decimal Irtra { get; set; }
        public Decimal BonoPaterniad { get; set; }
        public Decimal SalarioTotal { get; set; }
        public Decimal SalarioLiquido { get; set; }
        public string Creado_por { get; set; }
    }
}