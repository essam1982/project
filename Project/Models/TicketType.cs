using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class TicketType
    {
        [Key]
        public int TicketTypeId{get; set;}
        
        [Required, StringLength(15)]
        public string Name {get; set;}
        
        [StringLength(100)]
        public string Description{get; set;}
        
        [Required]
        public double OffPeakPrice  {get; set;}
        
        [Required] 
        public double PeakPrice {get; set;}
        
        public double ExtraCharge3D{get; set;}
        
        public double ExtraChargeIMax{get; set;}
        
        public double ExtraChargeBlockBuster{get; set;}   
        
    }
}
