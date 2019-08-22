using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaT.Models.ViewModel
{
    public class RestaurarPass
    {
        [Required]
        [EmailAddress]
        public string email {get; set;}
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento {get; set;}
    }
}