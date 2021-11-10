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
            beater1 = new Beater("Wee Hands Mallets", 2.45, 5.50, ItemCategory.Accessories, "child", true);
            cleaner1 = new Cleaner("Trumpet valve stick", 4.20, 8.99, ItemCategory.Maintenance, InstrumentType.Brass,
                false);
        }

        [Test]
        public void ItemHasName()
        {
            beater1.GetName().ShouldBe("Wee Hands Mallets");
            cleaner1.GetName().ShouldBe("Trumpet valve stick");
        }

        [Test]
        public void ItemHasBuyingPrice()
        {
            beater1.GetBuyingPrice().ShouldBe(2.45);
            cleaner1.GetBuyingPrice().ShouldBe(4.20);
        }

        [Test]
        public void ItemHasSellingPrice()
        {
            beater1.GetSellingPrice().ShouldBe(5.50);
            cleaner1.GetSellingPrice().ShouldBe(8.99);
        }

        [Test]
        public void ItemHasItemCategory()
        {
            beater1.GetCategory().ShouldBe(ItemCategory.Accessories);
            cleaner1.GetCategory().ShouldBe(ItemCategory.Maintenance);
        }

        [Test]
        public void BeaterHasAgeRange()
        {
            beater1.GetAgeRange().ShouldBe("child");
        }

        [Test]
        public void BeaterHasPairBool()
        {
            beater1.GetPair().ShouldBe(true);
        }

        [Test]
        public void CleanerHasInstrumentFor()
        {
            cleaner1.GetInstrumentFor().ShouldBe(InstrumentType.Brass);
        }

        [Test]
        public void CleanerHasChemicalBool()
        {
            cleaner1.GetChemicalCleaner().ShouldBe(false);
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
