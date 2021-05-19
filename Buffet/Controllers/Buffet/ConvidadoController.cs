using System;
using System.Collections.Generic;
using System.Diagnostics;
using Buffet.Models.Buffet.Convidado;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers
{
    public class ConvidadoController : Controller
    {
        private readonly ConvidadoService _convidadoService;

        public ConvidadoController(ConvidadoService convidadoService)
        {
            _convidadoService = convidadoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        
        public IActionResult Editar()
        {
            return View();
        }
        
        public IActionResult Remover()
        {
            return View();
        }
    }
}