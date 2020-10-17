using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.DTO.DTOs.AppUserDtos
{
    public class AppUserSignInDto
    {
        //[Required(ErrorMessage = "Kullanıcı adı boş geçilemez.")]
        //[Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Parola alanı boş geçilemez.")]
        //[Display(Name = "Şifre :")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        //[Display(Name ="Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
