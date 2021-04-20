using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Buffet.Models;
using Buffet.ViewModels.Home;

namespace Buffet.Controllers.Admin
{
    public class PainelDoUsuarioController : Controller
    {
        public PainelDoUsuarioController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}