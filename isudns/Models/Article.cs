using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace isudns.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Display(Name = "Название работы")]
        public string Name { get; set; }

        [Display(Name = "Текст работы")]
        public string Text { get; set; }

        [Display(Name = "Дата создания")]
        [DataType(DataType.Date)]
        public DateTime? CreationDate { get; set; }

        public string ApplicationUserId { get; set; }
        [Display(Name = "Автор")]
        public ApplicationUser ApplicationUser { get; set; }


    }
}
