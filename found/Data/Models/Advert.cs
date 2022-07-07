using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace found.Data.Models
{
    public class Advert
    {
        [BindNever]
        public int id { get; set; }
        public int Usersid { get; set; }
        [Display(Name = "Время:")]
        [DataType(DataType.Time)]
        [StringLength(5)]
        [Required(ErrorMessage = "Название должно содержать более 4 символов")]
        public string time { get; set; }
        [Display(Name = "Место находки:")]
        [StringLength(8)]
        [Required(ErrorMessage = "Обязательное поле")]
        public string location { get; set; }
        [Display(Name = "Предмет:")]
        [StringLength(20)]
        [Required(ErrorMessage ="Обязательное поле")]
        public string desc_short { get; set; }
        [Display(Name = "Описание:")]
        [StringLength(50)]
        [Required(ErrorMessage = "Описание должно содержать5 и более символов")]
        public string desc_long { get; set; }
        public bool isActive { get; set; }
        public bool isApprove { get; set; }
        public string img { get; set; }
        public virtual Users Users { get; set; }
    }
}
