using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WOSAPI.Data;
using WOSAPI.Models;

namespace WOSAPI_WebApp.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        // GET: /api/users
        public List<User> Get()
        {
            using (WosContext ctx = new WosContext())
            {
                return ctx.Users.ToList();
            }
        }
    }
}