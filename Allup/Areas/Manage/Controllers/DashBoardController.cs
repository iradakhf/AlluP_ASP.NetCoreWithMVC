using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize]
    public class DashBoardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
