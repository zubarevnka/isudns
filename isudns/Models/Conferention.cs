﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isudns.Models
{
    public class Conferention
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
