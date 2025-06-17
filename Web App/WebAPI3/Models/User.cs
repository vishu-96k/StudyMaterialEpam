using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CodeFirst.Models;


namespace WebAPI3.Models
{
    public class User
{
    [Key]
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