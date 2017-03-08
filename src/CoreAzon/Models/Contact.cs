using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAzon.Models
{
    public class Contact
    {
        [Required]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(35)]
        public string LastName { get; set; }

        // You can add these data annotation attributes like below, or above. It's personal preference.
        [MinLength(2), MaxLength(35)]
        public int Id { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
