using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class User : IEntity<Guid>
    {
        public Guid ID { get; set; }

        public virtual ICollection<Blame> Blames { get; set; }
    }
}
