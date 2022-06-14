using AutoGlassMarket.Content;
using AutoGlassMarket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AutoGlassMarket.ViewsModel
{
    public class ShopItemViewModel
    {
        public IEnumerable<CarsBrand> AllCars { get; set; }
        public IEnumerable<CarsBrand> GetModels { get; set; }
        public IEnumerable <CarsBrand> GetBrands { get; set; }
        public IEnumerable<CarsBrand> GetcarType { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(35, ErrorMessage = "Максимальная длинна 35символов")]
        public string UserName { get; set; }
        [Required]
        public int UserNumber { get; set; }
        public string ProductInformation { get; set; }

        public string openModel { get; set; }
        public string openType { get; set; }
    }
}
 