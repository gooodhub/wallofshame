using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using WOSAPI.Data.Repositories;
using WOSAPI.Models;
using WOSAPI_WebApp.Models;

namespace WOSAPI_WebApp.Controllers
{
    [Authorize]
    public class ShamesController : ApiController
    {
        // GET /api/shames
        public List<ShameViewModel> Get()
        {
            using (ShameRepository repo = new ShameRepository(User.Identity.GetUserId()))
                return repo.Get().Select(s => new ShameViewModel
                {
                    ID = s.ID,
                    Name = s.Name,
                    ImagePath = s.ImagePath
                }).ToList();
        }

        // POST /api/shames
        public void Post(ShameViewModel shame)
        {
            using (ShameRepository repo = new ShameRepository(User.Identity.GetUserId()))
                repo.Add(new Shame
                {
                    ID = shame.ID,
                    Name = shame.Name,
                    ImagePath = shame.ImagePath
                });
        }
    }
}
