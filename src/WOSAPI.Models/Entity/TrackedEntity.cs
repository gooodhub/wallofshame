using System;
using System.ComponentModel.DataAnnotations;

namespace WOSAPI.Models.Entity
{
    public class TrackedEntity
    {
        public DateTime CreatedAt { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }
    }
}
