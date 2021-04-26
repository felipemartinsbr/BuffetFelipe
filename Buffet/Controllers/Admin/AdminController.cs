using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers.Admin
{
    [Authorize]
    public  class AdminController : Controller
    {
        public AdminController()
        {
        }
        
        public IActionResult Supervisao()
        {
            return View();
        }
    }
}