using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PruebaT.Interfaces;
using PruebaT.Models;
using PruebaT.Models.DAL;
using PruebaT.Repositorios;

namespace PruebaT.Controllers
{
    public class EmpleadoController : Controller
    {
        private IEmpleado _empleadoRepository;

        public EmpleadoController(PruebaTcontext context)
        {
            this._empleadoRepository = new EmpleadoRepository(context);
        }
        public IActionResult Index()
        {
            var empleados = from empleado in _empleadoRepository.GetEmpleado()
                            select empleado;

            return View(empleados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {   empleado.Creado_por = "marlon";
                    _empleadoRepository.InsertarEmpleado(empleado);
                    _empleadoRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "No se pueden Guardar los cambios.Intenta de nuevo, si el problema persiste contacta al Administrador");
            }
            return View(empleado);
        }

        public ActionResult Edit(int id)
        {
            Empleado empleado = _empleadoRepository.GetEmpleadoById(id);

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Edit(Empleado empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _empleadoRepository.UpdateEmpleado(empleado);
                    _empleadoRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "No se pueden Guardar los cambios. Intenta de nuevo, si el problema persiste contacta al Administrador");
            }
            return View(empleado);
        }

        public ViewResult Details(int id)
        {
            Empleado empleado = _empleadoRepository.GetEmpleadoById(id);

            return View(empleado);
        }
    }
}
