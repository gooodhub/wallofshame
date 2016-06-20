using System.Collections.Generic;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class User : IEntity<long>
    {
        public long ID { get; set; }

        public virtual ICollection<Blame> Blames { get; set; }
    }
}
