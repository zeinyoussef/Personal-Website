﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Personal_Website.Controllers
{
    public class ZeinYoussefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}