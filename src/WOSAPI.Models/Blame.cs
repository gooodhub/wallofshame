﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOSAPI.Models.Entity;

namespace WOSAPI.Models
{
    public class Blame : IEntity<long>
    {
        public long ID { get; set; }

        public string Name { get; set; }
    }
}
