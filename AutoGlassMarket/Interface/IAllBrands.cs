using AutoGlassMarket.Models;
using System.Collections.Generic;

namespace AutoGlassMarket.Interface
{
    public interface IAllBrands
    {
        IEnumerable<CarsBrand> allCars { get; }

        
        CarsBrand GetById(int carId);
    }
}
    