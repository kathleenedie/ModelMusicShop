using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ModelMusicShop.Tests
{
    public class DrumTests
    {
        private Drum drum1;

        [SetUp]
        public void Setup()
        {
            drum1 = new Drum("Sonor V171 Rotary Timpany", InstrumentType.Percussion, 212.25, 566.00, "paat paat",
                "ash");
        }

        [Test]
        public void DrumHasName()
        {
            drum1.GetName().ShouldBe("Sonor V171 Rotary Timpany");
        }

        [Test]
        public void DrumHasInstrumentType()
        {
            drum1.GetInstrumentType().ShouldBe(InstrumentType.Percussion);
        }

        [Test]
        public void DrumHasBuyingPrice()
        {
            drum1.GetBuyingPrice().ShouldBe(212.25);
        }

        [Test]
        public void DrumHasSellingPrice()
        {
            drum1.GetSellingPrice().ShouldBe(566.00);
        }

        [Test]
        public void DrumHasSound()
        {
            drum1.GetSound().ShouldBe("paat paat");
        }

        [Test]
        public void DrumHasMaterial()
        {
            drum1.GetMaterial().ShouldBe("ash");
        }

        [Test]
        public void DrumCanPlay()
        {
            drum1.Play().ShouldBe("When I play you hear paat paat");
        }

        [Test]
        public void DrumCanCalculateGrossProfit()
        {
            drum1.CalculateGrossProfit().ShouldBe(353.75);
        }

        [Test]
        public void DrumCanCalculateMarkup()
        {
            drum1.CalculateMarkup().ShouldBe(167);
        }
    }
}
