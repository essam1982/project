using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class BookingTicket
  {
    [Key]
    public int BookingNo {get;set;}
    
    public int TicketTypeId {get;set;}
    
    public double Price{get;set;}
    
    public int Quantity {get;set;}
  }
}
