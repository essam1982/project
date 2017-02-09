using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class Customer
  {
    [Required]
    public string CustomerId{get; set}
    
    [Required]
    public DateTime DateOfBirth{get;set;}
    
    [StringLength(20)]
    public class DisplayName{get;set;}
    
    [StringLength(50)]
    public class Address{get;set;}
    
    [StringLength(30)]
    public class City(get;set;}
    
    [StringLength(8)]
    public class Postcode{get;set;}
    
  }
}
