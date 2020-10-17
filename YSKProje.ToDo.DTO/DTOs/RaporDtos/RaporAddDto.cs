using System.ComponentModel.DataAnnotations;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DTO.DTOs.RaporDtos
{
    public class RaporAddDto
    {
        [Display(Name ="Tanım :")]
        [Required(ErrorMessage ="Tanım alanı boş geçilemez.")]
        public string Tanim { get; set; }
        [Display(Name = "Görev :")]
        [Required(ErrorMessage = "Detay alanı boş geçilemez.")]
        public string Detay { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
    }
}
