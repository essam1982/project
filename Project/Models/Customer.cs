using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class Customer
  {
    [Key,Required]
    public string CustomerId{get; set}
    
    [Required]
    public DateTime DateOfBirth{get;set;}
    
    [StringLength(20)]
    public string DisplayName{get;set;}
    
    [StringLength(50)]
    public string Address{get;set;}
    
    [StringLength(30)]
    public string City(get;set;}
    
    [StringLength(8)]
    public string Postcode{get;set;}
    
  }
}
