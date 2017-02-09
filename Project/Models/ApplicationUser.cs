using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class ApplicationUser
  {
    [Required, StringLength(30)]
    public string FirstName{get; set;}
    
    [Required, StringLength(30)]
    public string LastName{get; set;}
    
    [Required]
    public System.DateTime Created{get; set;}
    
    public System.DateTime LastLogin{get;set;}
    
  }
}
