using System;
using System.Collections.Generic;
using System.Diagnostics;
using Buffet.Models.Buffet.Evento;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers
{
    public class EventoController : Controller
    {
        private readonly EventoService _eventoService;

        public EventoController(EventoService eventoService)
        {
            _eventoService = eventoService;
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