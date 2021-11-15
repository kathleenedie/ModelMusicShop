using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ModelMusicShop.Tests
{
    public class ItemTests
    {
        private Beater beater1;
        private Cleaner cleaner1; 

        [SetUp]
        public void SetUp()
        {
            beater1 = new Beater("Wee Hands Mallets", 2.45, 5.50, "child", true);
            cleaner1 = new Cleaner("Trumpet valve stick", 4.20, 8.99,  InstrumentType.Brass,
                false);
        }

        [Test]
        public void ItemHasName()
        {
            beater1.Name.ShouldBe("Wee Hands Mallets");
            cleaner1.Name.ShouldBe("Trumpet valve stick");
        }

        [Test]
        public void ItemHasBuyingPrice()
        {
            beater1.BuyingPrice.ShouldBe(2.45);
            cleaner1.BuyingPrice.ShouldBe(4.20);
        }

        [Test]
        public void ItemHasSellingPrice()
        {
            beater1.SellingPrice.ShouldBe(5.50);
            cleaner1.SellingPrice.ShouldBe(8.99);
        }

        [Test]
        public void ItemHasItemCategory()
        {
            beater1.Category.ShouldBe(ItemCategory.Accessories);
            cleaner1.Category.ShouldBe(ItemCategory.Maintenance);
        }

        [Test]
        public void BeaterHasAgeRange()
        {
            beater1.AgeRange.ShouldBe("child");
        }

        [Test]
        public void BeaterHasPairBool()
        {
            beater1.Pair.ShouldBe(true);
        }

        [Test]
        public void CleanerHasInstrumentFor()
        {
            cleaner1.InstrumentFor.ShouldBe(InstrumentType.Brass);
        }

        [Test]
        public void CleanerHasChemicalBool()
        {
            cleaner1.ChemicalCleaner.ShouldBe(false);
        }

        [Test]
        public void ItemCanCalculateGrossProfit()
        {
            beater1.CalculateGrossProfit().ShouldBe(3.05);
            cleaner1.CalculateGrossProfit().ShouldBe(4.79);
        }

        [Test]
        public void ItemCanCalculateMarkup()
        {
            beater1.CalculateMarkup().ShouldBe(124);
            cleaner1.CalculateMarkup().ShouldBe(114);
        }
    }
}
