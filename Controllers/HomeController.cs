using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Eval.Models;

namespace Eval.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Docentes(){
            ListaDocente();
            return View();
        }
        public IActionResult CrearDocente(){
            ViewBag.ListaMaterias=BD.GetMaterias();
            return View();
        }
        public IActionResult GuardarDocente(Docente docente){
            if(BD.GetDocenteByIdMateria(docente.IdMateria)||string.IsNullOrEmpty(docente.NombreDocente)||string.IsNullOrEmpty(docente.FotoDocente)||docente.AntiguedadDocente==null||docente.IdMateria==null){
                ViewBag.ListaMaterias=BD.GetMaterias();
                ViewBag.Error="Error. Nombre del Docente vacío o la Materia elegida ya tiene docente";
                return View("CrearDocente");
            }else{
                BD.InsertDocente(docente);
                ListaDocente();
                return View("Docentes");
            }
        }
        public IActionResult VerDetalleDocente(int IdDocente){
            ViewBag.Docente=BD.GetDocenteById(IdDocente);
            return View();
        }
        public IActionResult EliminarDocente(int IdDocente){
            BD.DeleteDocenteById(IdDocente);
            ListaDocente();
            return View("Docentes");
        }
        void ListaDocente(){
            int AntiguedadDocente=1, Contador=-1;
            ViewBag.ListaDocentes=BD.GetDocentes();
            foreach (Docente item in ViewBag.ListaDocentes){
                AntiguedadDocente+=item.AntiguedadDocente;
                Contador++;
            }
            if(Contador>-1){
                Contador+=1;
                AntiguedadDocente-=1;
            }
            ViewBag.PromedioDocentes=AntiguedadDocente/Contador;
        }
    }
}