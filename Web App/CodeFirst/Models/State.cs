using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class State
    {
        [Key]
        public int StateID { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }
    }
}