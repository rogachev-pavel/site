using AutoGlassMarket.Content;
using AutoGlassMarket.Interface;
using AutoGlassMarket.Models;
using System.Collections.Generic;

namespace AutoGlassMarket.Repository
{
    public class BuyersRepository : IBuyers
    {
        private readonly AppDBContext appDBContext;

        public BuyersRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Buyers> buyers {
            get => appDBContext.allBuyersRP; 
            set =>  appDBContext.allBuyersRP.AddRange(); 
        }
    }
}