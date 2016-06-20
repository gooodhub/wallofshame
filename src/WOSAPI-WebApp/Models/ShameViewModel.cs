using System.Collections.Generic;

namespace WOSAPI_WebApp.Models
{
    public class ShameViewModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public ICollection<BlameViewModel> Blames { get; set; }
    }
}