using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class Shame : IEntity<long>
    {
        public long ID { get; set; }

        [StringLength(100), Required]
        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public virtual ICollection<Blame> Blames { get; set; }
    }
}
