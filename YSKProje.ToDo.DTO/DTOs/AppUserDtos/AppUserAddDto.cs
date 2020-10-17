using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.DTO.DTOs.AppUserDtos
{
    public class AppUserAddDto
    {
        //[Required(ErrorMessage = "Kullanıcı adı boş geçilemez.")]
        //[Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Parola alanı boş geçilemez.")]
        //[Display(Name = "Şifre :")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        //[Compare("Password", ErrorMessage = "Parolalar Eşleşmiyor.")]
        //[Display(Name = "Şifre Tekrar :")]
        //[DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage = "Email boş geçilemez.")]
        //[EmailAddress(ErrorMessage ="Geçersiz Email.")]
        //[Display(Name = "Email :")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        //[Display(Name = "Ad :")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        //[Display(Name = "Soyad :")]
        public string SurName { get; set; }
    }
}
