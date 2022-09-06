using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Petsani.Models
{
    public class mCity
    {   [Key]
        public int Id { get; set; }
        
        [Required]
        public string CityName { get; set; }
    }
}