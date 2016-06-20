using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class Shame : IEntity<long>
    {
        public long ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
