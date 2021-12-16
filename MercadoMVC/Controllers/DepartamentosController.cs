using MercadoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamentos> lista = new List<Departamentos>();
            lista.Add(new Departamentos { Id = 1, Name = "Eletronicos" });
            lista.Add(new Departamentos { Id = 2, Name = "Alimentos" });

            return View(lista);
        }
    }
}
