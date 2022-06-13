using AutoGlassMarket.Models;
using System.Collections.Generic;

namespace AutoGlassMarket.Interface
{
    public interface IBuyers
    {
        IEnumerable<Buyers> buyers { get; set; }
    }
}
