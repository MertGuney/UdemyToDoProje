using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.DTO.DTOs.AciliyetDtos
{
    public class AciliyetUpdateDto
    {
        public int Id { get; set; }
        //[Display(Name = "Tanım :")]
        //[Required(ErrorMessage = "Tanım Alanı Boş Geçilemez.")]
        public string Tanim { get; set; }
    }
}
