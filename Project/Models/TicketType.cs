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
        private double OffPeakPrice  {get, 
        
        
    }
}
