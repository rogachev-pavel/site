using AutoGlassMarket.Content;
using AutoGlassMarket.Interface;
using AutoGlassMarket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AutoGlassMarket.Repository
{
    public class GlassesRepository : IAllGlasses
    {
        private readonly AppDBContext appDBContext;


        public GlassesRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Glasses> allGlasses => appDBContext.allGlassesRP.AsNoTracking();
    }
}
