using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ModelMusicShop.Tests
{
    public class ShoapTests
    {
        public Shoap shop1;
        public Guitar guitar2;
        public Guitar guitar3;
        public Drum drum2;
        public Beater beater2;
        public Cleaner cleaner2;
        public Cleaner cleaner3;

        [SetUp]
        public void Setup()
        {
            
            guitar2 = new Guitar("Acoustic Guitar", 35.35, 59.95, "brruunngg", 5, "Martin Smith");
            guitar3 = new Guitar("F310", 65.00, 119.00, "twang", 5, "Yamaha");
            drum2 = new Drum("highhat",  22.40, 85.00, "tsaatsaa", "zinc");
            beater2 = new Beater("Bass Basher", 12.50, 18.00, "adult", false);
            cleaner2 = new Cleaner("Brasso", 0.98, 1.89,  InstrumentType.Brass, true);
            cleaner3 = new Cleaner("Bagpipe Brush", 8.99, 15.99, InstrumentType.Wind, false);
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void ShopHasName()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.Name.ShouldBe("Jay's Jazzy Jukebox");
        }

        [Test]
        public void ShopHasInitialEmptyStock()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.StockCount().ShouldBe(0);
        }

        [Test]
        public void ShopHasCorrectFloat()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.Float.ShouldBe(100.00);
        }

        [Test]
        public void ShopHasInitialTillTotalOfFloat()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.Till.ShouldBe(100.00);
        }

        [Test]
        public void ShopCanCountInstruments()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);

            shop1.StockCountOfInstruments().ShouldBe(3);
        }

        [Test]
        public void ShopCanAddStock()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);
            
            shop1.StockCount().ShouldBe(4);
        }

        [Test]
        public void ShopCanRemoveStock()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);
            shop1.RemoveStockItem(guitar3);

            shop1.StockCount().ShouldBe(3);
        }

        [Test]
        public void ShopCanRemoveSpecificStockItem()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);
            shop1.RemoveStockItem(guitar3);

            shop1.StockCountOfInstruments().ShouldBe(2);
        }

        [Test]
        public void ShopCanCalculateStockProfitTotal()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(beater2);
            shop1.AddStockItem(cleaner2);
            shop1.AddStockItem(cleaner3);

            shop1.CalculateStockProfitTotal().ShouldBe(154.61);
        }

        [Test]
        public void ShopTillIncreasesAfterSale()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(beater2);
            shop1.SellItem(guitar3);

            shop1.Till.ShouldBe(219.00);
        }

        [Test]
        public void ShopStockListDecreasesAfterSale()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(beater2);
            shop1.SellItem(guitar3);

            shop1.StockCount().ShouldBe(3);
        }

        [Test]
        public void ShopSoldListIncreasesAfterSale()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 0);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(beater2);
            shop1.SellItem(guitar3);

            shop1.Sold.Count.ShouldBe(1);
        }

        [Test]

        public void StockTotalProfitAfterSaleDiscount()
        {
            var shop1 = new Shoap("Jay's Jazzy Jukebox", 10);
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(beater2);

            shop1.StockSaleProfitValue().ShouldBe(132.03);
        }
    }
}
