using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TLC_WebApp.Controllers
{
    public class AJAXController : Controller
    {
        public IActionResult GameBoardPartial()
        {
            return PartialView();
        }
    }
}