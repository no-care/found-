using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Models
{
    public class Authorize
    {
        [Display(Name = "Логин:")]
        [StringLength(20)]
        [Required(ErrorMessage = "Логин должен содержать более 3 символов")]
        public string login { get; set; }
        [Display(Name = "Пароль:")]
        [StringLength(30)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Пароль должен быть длинее 5 символов")]
        public string password { get; set; }
    }
}
