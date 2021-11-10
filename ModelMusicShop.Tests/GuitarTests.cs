using System;
using NUnit.Framework;
using Shouldly;

namespace ModelMusicShop.Tests
{
    public class GuitarTests
    {
        private Guitar guitar1;

        [SetUp]
        public void Setup()
        {
            guitar1 = new Guitar("L-00 Deluxe", InstrumentType.String, 1236.52, 2844.99, "struummm", 6, "Gibson");
        }

        [Test]
        public void GuitarHasName()
        {
            guitar1.GetName().ShouldBe("L-00 Deluxe");
        }

        [Test]
        public void GuitarHasInstrumentType()
        {
            guitar1.GetInstrumentType().ShouldBe(InstrumentType.String);
        }

        [Test]
        public void GuitarHasBuyingPrice()
        {
            guitar1.GetBuyingPrice().ShouldBe(1236.52);
        }

        [Test]
        public void GuitarHasSellingPrice()
        {
            guitar1.GetSellingPrice().ShouldBe(2844.99);
        }

        [Test]
        public void GuitarHasSound()
        {
            guitar1.GetSound().ShouldBe("struummm");
        }

        [Test]
        public void GuitarHasNumStrings()
        {
            guitar1.GetNumStrings().ShouldBe(6);
        }

        [Test]
        public void GuitarHasBrand()
        {
            guitar1.GetBrand().ShouldBe("Gibson");
        }

        [Test]
        public void GuitarCanPlay()
        {
            guitar1.Play().ShouldBe("When I play you hear struummm");
        }

        [Test]
        public void GuitarCanGrossProfit()
        {
            guitar1.CalculateGrossProfit().ShouldBe(1608.47);
        }

        [Test]
        public void GuitarCanCalculateMarkup()
        {
            guitar1.CalculateMarkup().ShouldBe(130);
        }
    }
}
