using MVCClinica.Admin;
using MVCClinica.Filters;
using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClinica.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            return View("Index", AdmMedico.Listar());
        }

        public ActionResult Create()
        {
            Medico medico = new Medico();
            return View("Create", medico);
        }

        [MyFilterAction]
        [HttpPost]
        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Crear(medico);
                return RedirectToAction("Index");
            }
            return View("Create", medico);
        }
        public ActionResult Detail(int id)
        {
            Medico medico = AdmMedico.BuscarPorId(id);
            if (medico != null)
            {
                return View("Detail", medico);
            }
            else
            {
                return HttpNotFound();
            }
        }
        public ActionResult Delete(int id)
        {
            Medico medico = AdmMedico.BuscarPorId(id);
            if (medico != null)
            {
                return View("Delete", medico);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Medico medico = AdmMedico.BuscarPorId(id);
            AdmMedico.Eliminar(medico);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Medico medico = AdmMedico.BuscarPorId(id);
            if (medico != null)
            {
                return View("Edit", medico);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Medico medico)
        {
            if (ModelState.IsValid)
            {
                AdmMedico.Modificar(medico);
                return RedirectToAction("Index");
            }
            return View("Edit", medico);
        }
        public ActionResult IndexEspecialidad()
        {
            Medico medico = new Medico();
            return View("IndexEspecialidad", AdmMedico.ListarPorEspecialidad(medico.Especialidad));
        }
        public ActionResult SearchByEspecialidad(string especialidad)
        {
            if (especialidad == null)
                return RedirectToAction("Index");
            return View("Index", AdmMedico.ListarEspecialidad(especialidad));
        }

        public ActionResult SearchByName(string name, string surname)
        {
            if (name == null && surname == null)
            {
                return RedirectToAction("Index");
            }
            return View("Index", AdmMedico.ListFullName(name, surname));

            //var medicos = (from medic in context.Medicos
            //               where medic.Nombre == name
            //               where medic.Apellido == surname
            //               select medic).ToList();

            //return View("Index", medicos);
        }
    }
}
