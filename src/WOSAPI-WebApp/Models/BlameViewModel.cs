using System;

namespace WOSAPI_WebApp.Models
{
    public class BlameViewModel
    {
        public long ID { get; set; }

        public DateTime DateCreation { get; set; }

        public ShameViewModel Shame { get; set; }

        public Guid UserID { get; set; }
    }
}