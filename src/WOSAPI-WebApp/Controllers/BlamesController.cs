using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using WOSAPI.Data.Repositories;
using WOSAPI.Models;
using WOSAPI_WebApp.Models;

namespace WOSAPI_WebApp.Controllers
{
    [Authorize]
    public class BlamesController : ApiController
    {
        // GET /api/blames/{id}
        public BlameViewModel Get(long id)
        {
            using (BlameRepository repo = new BlameRepository(User.Identity.GetUserId()))
            {
                Blame blame = repo.Get().SingleOrDefault(b => b.ID == id);
                if (blame == null)
                    throw new HttpResponseException(HttpStatusCode.NotFound);

                return new BlameViewModel
                {
                    ID = blame.ID,
                    CreatedAt = blame.CreatedAt,
                    CreatedBy = blame.CreatedBy,
                    ShameID = blame.ShameID,
                    UserID = blame.UserID
                };
            }
        }

        // POST /api/blames
        public void Post(BlameViewModel blame)
        {
            using (BlameRepository repo = new BlameRepository(User.Identity.GetUserId()))
            {
                repo.Add(new Blame
                {
                    ShameID = blame.ShameID,
                    UserID = blame.UserID
                });
            }
        }
    }
}