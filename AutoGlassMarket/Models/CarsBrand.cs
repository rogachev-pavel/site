using System.ComponentModel.DataAnnotations;

namespace AutoGlassMarket.Models
{
    public class CarsBrand
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string carModel { get; set; }
        [MaxLength(50)]
        public string cartype { get; set; }
        [MaxLength(50)]
        public string bodytype { get; set; }
        [MaxLength(50)]
        public string carReleaseDate { get; set; }
        [MaxLength(50)]
        public string size{ get; set; }
        [Required]
        [MaxLength(50)]
        public uint price { get; set; }
        [MaxLength(100)]
        public string fullinfo { get; set; }


        public int GlassesId { get; set; }
        public virtual Glasses Glasses { get; set; }

    }
}
