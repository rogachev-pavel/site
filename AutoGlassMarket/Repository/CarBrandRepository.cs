using AutoGlassMarket.Content;
using AutoGlassMarket.Interface;
using AutoGlassMarket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AutoGlassMarket.Repository
{
    public class CarBrandRepository : IAllBrands
    {
        private readonly AppDBContext appDBContext;


        public CarBrandRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<CarsBrand> allCars => appDBContext.allCarsRP.Include(c => c.Glasses).AsNoTracking();

        public CarsBrand GetById(int carId) => appDBContext.allCarsRP.FirstOrDefault(p=>p.Id == carId);

    }
}
