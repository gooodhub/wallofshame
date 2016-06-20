using System;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class Blame : TrackedEntity, IEntity<long>
    {
        public long ID { get; set; }

        public long ShameID { get; set; }
        public virtual Shame Shame { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
    }
}
