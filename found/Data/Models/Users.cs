using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Models
{
    public class Users
    {
        public int id { get; set; }
        [Display(Name = "Логин:")]
        [StringLength(20)]
        [Required(ErrorMessage = "Логин должен содержать более 3 символов")]
        public string login { get; set; }
        [Display(Name = "Email:")]
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Почта должна содержать более 10 символов")]
        public string mail { get; set; }
        [Display(Name = "Пароль:")]
        [StringLength(30)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Пароль должен быть длинее 6 символов")]
        public string password { get; set; }
        public int roleid { get; set; }
        public virtual Roles Role { get; set; }
        public virtual ICollection<Advert> Advert { get; set; }
        public virtual ICollection<Dialogs> Dialogs { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
    }
}
