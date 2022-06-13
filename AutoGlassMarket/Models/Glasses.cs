using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoGlassMarket.Models
{
    public class Glasses
    {
        public int  Id { get; set; }
        public string typeGlass { get; set; }
        public string img { get; set; }


        [JsonIgnore]
        public List<CarsBrand> carsBrands { get; set; }
    }
}
