using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhondasSouthernScentsCandleStore.Models
{
    public class CandleCategory
    {
        public int CandleCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Candle> Candles { get; set; }
    }
}