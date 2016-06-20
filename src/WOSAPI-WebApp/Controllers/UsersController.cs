using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using WOSAPI.Data;
using WOSAPI_WebApp.Models;

namespace WOSAPI_WebApp.Controllers
{
    [Authorize]
    public class UsersController : ApiController
    {
        // GET: /api/users
        public List<UserViewModel> Get()
        {
            using (WosContext ctx = new WosContext(User.Identity.GetUserId()))
            {
                return ctx.Users.Select(u => new UserViewModel
                {
                    Email = u.Email,
                    Blames = u.Blames.Select(b => new BlameViewModel
                    {
                        ID = b.ID,
                        ShameID = b.ShameID,
                        UserID = b.UserID,
                        CreatedAt = b.CreatedAt,
                        CreatedBy = b.CreatedBy
                    }).ToList()
                }).ToList();
            }
        }
    }
}