using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace isudns.Models
{
    public class Conferention
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Дата проведения")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Место проведения")]
        public string Location { get; set; }
        public IEnumerable<ApplicationUserConferention> ApplicationUserConferentions { get; set; }

    }
}
