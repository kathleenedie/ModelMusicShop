using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ModelMusicShop.Tests
{
    public class ShoapTests
    {
        private Shoap shop1;
        private Guitar guitar2;
        private Guitar guitar3;
        private Drum drum2;
        private Beater beater2;
        private Cleaner cleaner2;
        private Cleaner cleaner3;

        [SetUp]
        public void Setup()
        {
            shop1 = new Shoap("Jay's Jazzy Jukebox");
            guitar2 = new Guitar("Acoustic Guitar", InstrumentType.String, 35.35, 59.95, "brruunngg", 5, "Martin Smith");
            guitar3 = new Guitar("F310", InstrumentType.String, 65.00, 119.00, "twang", 5, "Yamaha");
            drum2 = new Drum("highhat", InstrumentType.Percussion, 22.40, 85.00, "tsaatsaa", "zinc");
            beater2 = new Beater("Bass Basher", 12.50, 18.00, ItemCategory.Accessories, "adult", false);
            cleaner2 = new Cleaner("Brasso", 0.98, 1.89, ItemCategory.Maintenance, InstrumentType.Brass, true);
            cleaner3 = new Cleaner("Bagpipe Brush", 8.99, 15.99, ItemCategory.Maintenance, InstrumentType.Wind, false);
        }

        [Test]
        public void ShopHasName()
        {
            shop1.GetName().ShouldBe("Jay's Jazzy Jukebox");
        }

        [Test]
        public void ShopHasInitialEmptyStock()
        {
            shop1.StockCount().ShouldBe(0);
        }

        [Test]
        public void ShopCanCountInstruments()
        {
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);

            shop1.StockCountOfInstruments().ShouldBe(3);
        }

        [Test]
        public void ShopCanAddStock()
        {
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);
            
            shop1.StockCount().ShouldBe(4);
        }

        [Test]
        public void ShopCanRemoveStock()
        {
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
            shop1.AddStockItem(guitar2);
            shop1.AddStockItem(guitar3);
            shop1.AddStockItem(drum2);
            shop1.AddStockItem(cleaner2);
            shop1.RemoveStockItem(guitar3);

            shop1.StockCountOfInstruments().ShouldBe(2);
        }
    }
}
