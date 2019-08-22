using System;

namespace PruebaT.Models
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Email {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string password {get;set;}
        
        public string token{get;set;}
    }
}