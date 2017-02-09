using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class Booking
  {
    [Key]
    public int BookingNo{get;set;}
    
    [Required]
    public string CustomerId{get;set;}
    
    [StringLength(100)]
    public string Email {get;set;}
    
    [Required]
    public DateTime PurchaseDate {get;set;}
    
    [Required]
    public int FilmShowTimeId {get;set;}
    
    public int NoWheelchairs {get;set;}
    
    [StringLength(50)]
    public string BillingAddress {get;set;}
    
    [StringLength(30)]
    public string BillingCity{get;set;}
    
    [StringLength(8)]
    public string BillingPostcode {get;set;}
    
    [Required,StringLength(50)]
    public class PaymentDetails {get;set;}
    
    public double Discount {get;set;}
    
    public bool IsCancelled{get;set;}
    
    public double RefundAmount {get;set;}
    
  }
}
