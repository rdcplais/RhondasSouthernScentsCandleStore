using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RhondasSouthernScentsCandleStore.Models
{
    public class RhondasSouthernScentsCandleStoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RhondasSouthernScentsCandleStoreContext() : base("name=RhondasSouthernScentsCandleStoreContext")
        {
        }

        public System.Data.Entity.DbSet<RhondasSouthernScentsCandleStore.Models.Candle> Candles { get; set; }

        public System.Data.Entity.DbSet<RhondasSouthernScentsCandleStore.Models.CandleCategory> CandleCategories { get; set; }

        public System.Data.Entity.DbSet<RhondasSouthernScentsCandleStore.Models.Scent> Scents { get; set; }
    }
}
