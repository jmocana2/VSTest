using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();

            Persona per1 = new Persona();
            per1.codigo = 1;
            per1.nombre = "Pepe";
            per1.apepat = "López";
            per1.apemat = "Martín";
            lista.Add(per1);

            Persona per2 = new Persona();
            per2.codigo = 1;
            per2.nombre = "Pepe2";
            per2.apepat = "López";
            per2.apemat = "Martín";
            lista.Add(per2);

            Persona per3 = new Persona();
            per3.codigo = 1;
            per3.nombre = "Pepe3";
            per3.apepat = "López";
            per3.apemat = "Martín";
            lista.Add(per3);
            
            return View(lista);
        }
    }
}