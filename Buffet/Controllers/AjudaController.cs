using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers
{
    public class AjudaController : Controller
    {
        public AjudaController(){
        }

        public IActionResult Index()
        {   
            return View();
        }
    }
}