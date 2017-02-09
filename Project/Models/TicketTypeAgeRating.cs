using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class TicketTypeAgeRating
  {
    [Key]
    public int TicketTypeId{get;set;}
    
    [Key] 
    public int AgeRatingId{get; set;}
    
    
  }
}
