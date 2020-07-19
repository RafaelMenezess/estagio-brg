using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BRG.Models;

namespace BRG.Controllers
{
    public class ColaboradoresController : Controller
    {
        public IActionResult Index()
        {
            List<Colaborador> list = new List<Colaborador>();
            list.Add(new Colaborador { Id = 1, Cargo = "Soldador", Departamento = "Fabrica", Name = "Carlos" });
            list.Add(new Colaborador { Id = 2, Cargo = "RH", Departamento = "Escritorio", Name = "Maria" });
            return View(list);
        }
    }
}