using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace Project.Models
{
  public class FilmShowTimes
  {
    [Key]
    public int FilmShowTimeId{get; set;}
    
    [Required] 
    public int FilmId{get; set;}
    
    [Required]
    public DataTime ShowingDateTime{get; set;}
    
    public enum ViewingExperienceTypes
    {
      TwoD,
      ThreeD,
      iMax
    }
    [Required, EnumDataType(typeof(ViewingExperienceTypes))]
    public ViewingExperienceTypes ViewingExperienceType{get; set;}
    
    [Required]
    public int ScreenId{get;set;}
    
    public bool IsAudioDescribed{get; set;}
    
    public bool HasSubTitles{get; set;}
  }
}
