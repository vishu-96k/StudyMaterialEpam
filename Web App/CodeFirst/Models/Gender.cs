using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }

        [Required, StringLength(10)]
        public string Name { get; set; }
    }
}