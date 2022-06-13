using AutoGlassMarket.Models;
using System.Collections.Generic;

namespace AutoGlassMarket.Interface
{
    public interface IAllGlasses
    {
        IEnumerable<Glasses> allGlasses { get; }
    }
}
