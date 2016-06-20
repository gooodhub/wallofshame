using System;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class Blame : IEntity<long>
    {
        public long ID { get; set; }

        public DateTime DateCreation { get; set; }
        
        public Shame Shame { get; set; }

        public User User { get; set; }
    }
}
