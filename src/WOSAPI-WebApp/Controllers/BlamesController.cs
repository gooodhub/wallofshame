using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WOSAPI.Data;
using WOSAPI.Models;

namespace WOSAPI_WebApp.Controllers
{
    public class BlamesController : ApiController
    {
        // GET /api/blames
        public List<Blame> Get()
        {
            using (WosContext ctx = new WosContext())
            {
                return ctx.Blames.ToList();
            }
        }

        // POST /api/blames
        public void Post(Blame blame)
        {
            using (WosContext ctx = new WosContext())
            {
                ctx.Blames.Add(blame);
                ctx.SaveChanges();
            }
        }
    }
}
