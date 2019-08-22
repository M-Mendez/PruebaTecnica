using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaT.Models.ViewModel;

namespace PruebaT.Controllers
{
    public class PalindromosController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Lista = BuscarPalindromo("");

            ViewBag.Cantidad =  "";

            return View();
        }

        [HttpPost]
        public IActionResult Index(Palindromo model)
        {
            var palabras = BuscarPalindromo(model.cadena);

            ViewBag.Lista = palabras;
            ViewBag.Cantidad =  palabras.Count();
       
            return View(model);
        }

        private List<string> BuscarPalindromo(string cadena)
        {
            List<string> polindromos = new List<string>();

        //separamos la cadena por espacios
        string []Arreglo = cadena.Split(new Char [] {' ', '$', '.', '-'});

        string inverso, caracter;

        inverso = "";

          for(int i = 0; i < Arreglo.Length; i++)
          {
            
            int j = Arreglo[i].Length;

            for(int x = j - 1; x >= 0; x--)
            {
                caracter = Arreglo[i].Substring(x, 1);
                inverso = inverso + caracter;
            }

            if(inverso == Arreglo[i] && inverso.Length > 1)
            {
                polindromos.Add(inverso);
            }
               inverso = "";
          }
        return polindromos;
        }

    }
}
