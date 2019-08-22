using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PruebaT.Models.DAL;
using PruebaT.Models.ViewModel;
using PruebaT.Repositorios;
using PruebaT.Interfaces;

namespace PruebaTecnica.Controllers
{

    public class CuentasController: Controller
    {
        private Icuentas _cuentaRepository;

        public CuentasController(PruebaTcontext context)
        {
            _cuentaRepository = new CuentaRepository(context);
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Index(LoginVmodel model)
        {
            if(ModelState.IsValid)
            {
               string usuer = _cuentaRepository.obtenerUsuario(model);

                if(usuer != null)
                {
                    //ViewBag.Usuario = usuer;
                    RedirectToAction("Index", "Empleado");
                }else
                {
                    ViewBag.error = "Usuario o Contraseña no validos";
                    return View("Index");
                }
            }
            
            return View("Index", model);
        }

        public IActionResult RecuperarPass()
        {
         return View();
        }

        [HttpPost]
        public IActionResult RecuperarPass(RestaurarPass model)
        {
        ViewBag.Usuario = null;
         if(ModelState.IsValid)
            {
              
                if(_cuentaRepository.validarEmailCumpleanio(model))
                {
                    ViewBag.success = "Se envio un correo con el link para cambiar contraseña";
                    
                    return View();
                
                }else
                {
                    ViewBag.error = "Datos no validos, intente de nuevo";
                    return View(model);
                }
            }

         return View();
        }

        private bool tokenValido;
        public IActionResult Restaurar(string token)
        {
            cambiarPassVmodel model = new cambiarPassVmodel();

            model.token = token;
            tokenValido = _cuentaRepository.validarToken(token);

            if(tokenValido)
            {
            
            return View(model);

            }else{
                ViewBag.errorToken = "Token no valido, solicita uno nuevo";
            }
            return View("TokenVencido");
        }


        [HttpPost]
        public IActionResult Restaurar(cambiarPassVmodel model)
        {
            if(ModelState.IsValid)
            {
               var actualizar = _cuentaRepository.ActualizarPass(model);

                if(actualizar)
                {
                    ViewBag.success = "Datos Actulizados con Exito";
                    return View("Index");
                }else{
                    ViewBag.Error = "Ocurrio un error, intenta de nuevo";
                }
            }
            ViewBag.Error = "Ocurrio un error, intenta de nuevo";

            return View(model);
        }

    }
}