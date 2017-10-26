using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RhondasSouthernScentsCandleStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RhondasSouthernScentsCandleStoreEntities>
    {
        protected override void Seed(RhondasSouthernScentsCandleStoreEntities context)
        {
            var candlecategories = new List<CandleCategory>

            {
                new CandleCategory { CategoryName = "Jar Candles", CategoryDescription = "Jar Candles"},
                new CandleCategory { CategoryName = "Cubed Candles", CategoryDescription = "Cubed Candles"},
                new CandleCategory { CategoryName = "Halloween Candles", CategoryDescription = "Halloween Candles"},
                new CandleCategory { CategoryName = "Fall Candles", CategoryDescription = "Fall Candles"},
                new CandleCategory { CategoryName = "Christmas Candles", CategoryDescription = "Christmas Candles"},
                new CandleCategory { CategoryName = "Shop By Color", CategoryDescription = "Shop By Color"},
                new CandleCategory { CategoryName = "Festive Candles", CategoryDescription = "Festive Candles"},
                new CandleCategory { CategoryName = "Large Candles", CategoryDescription = "Large Candles"},
                new CandleCategory { CategoryName = "Vase Candles", CategoryDescription = "Vase Candles"},
                new CandleCategory { CategoryName = "Best Selling Candles", CategoryDescription = "Best Selling Candles"}
            };

            var artists = new List<Scent>
            {
                new Scent { ScentName = "Cucumber Melon" },
                new Scent { ScentName = "Vanilla" },
                new Scent { ScentName = "Butter Cream" },
                new Scent { ScentName = "Stawberries & Cream" },
                new Scent { ScentName = "Blueberry" },
                new Scent { ScentName = "Blackberry" }
            };

            new List<Candle>
            {
                new Candle { CandleDesc = "8 oz Jelly", CandleCategory = candlecategories.Single(g => g.CategoryName == "Jar Candle"), Price = 8.00M, Scent = artists.Single(a => a.ScentName == "Vanilla"), CandleImgUrl = "/Content/Images/Jar Candle2.png"},
                new Candle {CandleDesc = "12 oz Classic", CandleCategory = candlecategories.Single(g => g.CategoryName == "Jar Candle"), Price = 13.00M, Scent = artists.Single(a => a.ScentName == "Cucumber Melon"), CandleImgUrl = "/Content/Images/Jar Candle.jpg"},
                new Candle { CandleDesc = "16 oz Classic", CandleCategory = candlecategories.Single(g => g.CategoryName == "Jar Candle"), Price = 16.00M, Scent = artists.Single(a => a.ScentName == "Stawberries & Cream"), CandleImgUrl = "/Content/Images/untitled.png"},
                new Candle { CandleDesc = "16 oz Classic With Emblem", CandleCategory = candlecategories.Single(g => g.CategoryName == "Jar Candle"), Price = 18.00M, Scent = artists.Single(a => a.ScentName == "Blueberry"), CandleImgUrl = "/Content/Images/untitled.png "}
 }.ForEach(a => context.Candles.Add(a));
        }
    }
}