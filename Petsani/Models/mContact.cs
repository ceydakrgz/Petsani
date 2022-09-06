using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Petsani.Models
{
    public class mContact
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Lütfen en az 3 karakterlik isim giriniz!"), MaxLength(50, ErrorMessage = "Lütfen 50 karakterden uzun isim girmeyiniz!")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^([a-zA-Z0-9_\\.]+)@([a-zA-Z0-9_\\.]+).([a-zA-Z]{2,5})$", ErrorMessage = "Geçerli mail adresi giriniz!")]
        public string Email { get; set; }
        public int Tel { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}