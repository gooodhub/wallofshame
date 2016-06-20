using System;

namespace WOSAPI_WebApp.Models
{
    public class BlameViewModel
    {
        public long ID { get; set; }

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }

        public long ShameID { get; set; }
        public ShameViewModel Shame { get; set; }

        public Guid UserID { get; set; }
    }
}