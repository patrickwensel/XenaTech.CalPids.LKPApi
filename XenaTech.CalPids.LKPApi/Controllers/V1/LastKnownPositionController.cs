using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace XenaTech.CalPids.LKPApi.Controllers.V1
{
    public class LastKnownPositionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
