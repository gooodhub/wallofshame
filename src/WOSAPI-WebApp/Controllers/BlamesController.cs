using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WOSAPI.Models;

namespace WOSAPI_WebApp.Controllers
{
    public class BlamesController : Controller
    {
        // GET /api/blames
        public Blame Get(string id)
        {
            return new Blame();
        }
    }
}