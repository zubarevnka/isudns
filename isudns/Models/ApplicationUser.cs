using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace isudns.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "ФИО")]
        public string Name { get; set; }

        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Display(Name = "Дата Рождения")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Дата приема на работу")]
        [DataType(DataType.Date)]
        public DateTime? JobStartDate { get; set; }

        [Range(0, Double.PositiveInfinity)]
        [Display(Name = "Количество баллов")]
        public double Rating { get; set; }

        [Display(Name = "Мои научные работы")]
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<ApplicationUserConferention> ApplicationUserConferentions { get; set; }

    }
}
