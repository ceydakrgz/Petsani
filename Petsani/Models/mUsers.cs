using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Petsani.Models
{
    [Table("Users")]
    public class mUsers
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Adı :")]
        public string Name { get; set; }
        [Display(Name = "Soyadı :")]
        public string LastName { get; set; }
        [Display(Name = "E-Mail :")]
        [Required]
        [RegularExpression("^([a-zA-Z0-9_\\.]+)@([a-zA-Z0-9_\\.]+).([a-zA-Z]{2,5})$", ErrorMessage ="Geçerli mail adresi giriniz!")]
        public string EMail { get; set; }
        [Display(Name = "Şifre :")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Display(Name ="Şehir :")]
        public int City { get; set; }
        [Display(Name = "Kullanıcı Tipi :")]
        public int UserType { get; set; }
        [Display(Name = "Durum :")]
        public bool Status { get; set; }
    }
}