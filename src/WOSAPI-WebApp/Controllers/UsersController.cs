using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
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
            using (WosContext ctx = new WosContext(User.Identity.GetUserId()))
            {
                return ctx.Users.ToList();
            }
        }
    }
}