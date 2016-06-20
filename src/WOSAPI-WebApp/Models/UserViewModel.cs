using System.Collections.Generic;

namespace WOSAPI_WebApp.Models
{
    public class UserViewModel
    {
        public string Email { get; set; }

        public ICollection<BlameViewModel> Blames { get; set; }
    }
}