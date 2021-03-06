﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityTemplate.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]     
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret() 
        {
            return View();
        }
    }
}
