using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RhondasSouthernScentsCandleStore.Models
{
    [Bind(Exclude = "CandleId")]
    public class Candle
    {
        [ScaffoldColumn(false)]
        public int CandleID { get; set; }

        [DisplayName("Candle Category")]
        public int CandleCategoryID { get; set; }

        [DisplayName("Scent")]
        public int ScentID { get; set; }

        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        public string CandleDesc { get; set; }

        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price {get; set;}

        [DisplayName("Candle Image URL")]
        [StringLength(1024)]
        public string CandleImgUrl { get; set; }

        public virtual CandleCategory CandleCategory { get; set; }
        public virtual Scent Scent { get; set; }
    }
}