using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RhondasSouthernScentsCandleStore.Models
{
    public class RhondasSouthernScentsCandleStoreEntities : DbContext
    {
        public DbSet<Candle> Candles { get; set; }
        public DbSet<CandleCategory> CandleCategories { get; set; }
        public DbSet<Scent> Scents { get; set; }
    }
}