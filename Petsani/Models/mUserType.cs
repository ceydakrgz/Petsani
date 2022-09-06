using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Petsani.Models
{
    [Table("UserType")]
    public class mUserType
    {   
        [Key]
        public int ID { get; set; }
        
        [Display(Name ="Kullanıcı Tipi: ")]
        [MinLength(3,ErrorMessage ="Lütfen en az 3 karakterlik rol giriniz!"),MaxLength(20,ErrorMessage ="Lütfen 20 karakterden uzun rol girmeyiniz!")]
        public string TypeName { get; set; }
    }
}