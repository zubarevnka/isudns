using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace isudns.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        //[Required]

        public string Name { get; set; }
        public string Position { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        public DateTime JobStartDate { get; set; }

        public double Rating { get; set; }
        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
