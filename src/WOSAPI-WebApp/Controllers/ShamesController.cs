using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WOSAPI.Data;
using WOSAPI.Models;

namespace WOSAPI_WebApp.Controllers
{
    [Authorize]
    public class ShamesController : ApiController
    {
        // GET /api/shames
        public List<Shame> Get()
        {
            using (WosContext ctx = new WosContext())
            {
                return ctx.Shames.ToList();
            }
        }

        // POST /api/shames
        public void Post(Shame shame)
        {
            using (WosContext ctx = new WosContext())
            {
                ctx.Shames.Add(shame);
                ctx.SaveChanges();
            }
        }
    }
}
