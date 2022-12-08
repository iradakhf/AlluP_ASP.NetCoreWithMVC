using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return Content("Not Permitted");
        }
    }
}
