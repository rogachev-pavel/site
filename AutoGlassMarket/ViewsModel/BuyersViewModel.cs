using AutoGlassMarket.Models;
using System.Collections.Generic;

namespace AutoGlassMarket.ViewsModel
{
    public class BuyersViewModel
    {
        public IEnumerable<Buyers> buyers { get; set; }

        public string _Name { get; set; }
    }
}
