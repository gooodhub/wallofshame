using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WOSAPI.Models;
using WOSAPI_WebApp.Models;

namespace WOSAPI_WebApp.Controllers
{
    [Authorize]
    public class BlamesController : Controller
    {
        // GET /api/blames
        public BlameViewModel Get(string id)
        {
            return new BlameViewModel();
        }
    }
}