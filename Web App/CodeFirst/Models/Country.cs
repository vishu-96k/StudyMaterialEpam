using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}