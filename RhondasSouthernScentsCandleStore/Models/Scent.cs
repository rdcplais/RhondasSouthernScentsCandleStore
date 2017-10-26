using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhondasSouthernScentsCandleStore.Models
{
    public class Scent
    {
        public int ScentID { get; set; }
        public string ScentName { get; set; }
        public List<Candle> Candles { get; set; }
    }
}