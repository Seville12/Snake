﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Snake.Controllers
{
    /// <summary>
    /// Контроллер обработчика ошибок
    /// </summary>
    public class ErrorController : Controller
    {
        public IActionResult Error(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                if (statusCode.Value == 404 || statusCode.Value == 500)
                {
                    var viewName = statusCode.ToString();
                    return View(viewName);
                }
            }
            return View();
        }
    }
}