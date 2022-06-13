using System;
using System.ComponentModel.DataAnnotations;

namespace AutoGlassMarket.Models
{
    public class Buyers
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите имя")]
        [MaxLength(35, ErrorMessage ="Максимальная длинна 35символов")]
        public string UserName { get; set; }
        [Required]
        public long UserNumber { get; set; }

        
        [MaxLength(75, ErrorMessage = "Максимальная длинна 75символов")]
        public string ProductInformation { get; set; }


    }
}
