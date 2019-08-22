using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaT.Models.ViewModel
{
    public class cambiarPassVmodel
    {
        public string token {get;set;}
        
        [Required]
        public string password {get; set;} 
        
        [Compare("password")]
        [Required]
        public string password2 {get; set;} 
        
    }
}