using System;
using System.ComponentModel.DataAnnotations;

namespace MVCwebApi3.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [Phone, StringLength(15)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string Address { get; set; }
    }
}
