﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isudns.Models
{
    public class ApplicationUserConferention
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ConferentionId { get; set; }
        public Conferention Conferention  { get; set; }
    }
}
