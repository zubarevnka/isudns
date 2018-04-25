using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isudns.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Conferention> Conferentions { get; set; } = new List<Conferention>();
    }
}
