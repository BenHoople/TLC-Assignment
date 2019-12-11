using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TLC_WebApp.Data;
using TLC_WebApp.Models;

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