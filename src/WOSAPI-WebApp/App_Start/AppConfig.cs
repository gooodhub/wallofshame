using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WOSAPI.Data;
using WOSAPI_WebApp.Models;

namespace WOSAPI_WebApp
{
    public class AppConfig
    {
        public static void InitializeDatabase()
        {
            using (WosContext context = new WosContext(null))
            {
                context.Database.Initialize(false);
            }
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}