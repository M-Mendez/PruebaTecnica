using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaT.Models.ViewModel
{
    public class LoginVmodel
    {
        [Required]
        [EmailAddress]
        public string email {get; set;}
        
        [Required]
        [DataType(DataType.Password)]
        public string password {get; set;} 
    }
}