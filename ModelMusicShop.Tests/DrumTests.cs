using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Shouldly;

namespace ModelMusicShop.Tests
{
    public class DrumTests
    {
        [Test]
        public void DrumHasName()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.Name.ShouldBe("Sonor V171 Rotary Timpany");
        }

        [Test]
        public void DrumHasInstrumentType()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.InstrumentType.ShouldBe(InstrumentType.Percussion);
        }

        [Test]
        public void DrumHasBuyingPrice()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.BuyingPrice.ShouldBe(212.25);
        }

        [Test]
        public void DrumHasSellingPrice()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.SellingPrice.ShouldBe(566.00);
        }

        [Test]
        public void DrumHasSound()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.Sound.ShouldBe("paat paat");
        }

        [Test]
        public void DrumHasMaterial()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.GetMaterial().ShouldBe("ash");
        }

        [Test]
        public void DrumCanPlay()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.Play().ShouldBe("When I play you hear paat paat");
        }

        [Test]
        public void DrumCanCalculateGrossProfit()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.CalculateGrossProfit().ShouldBe(353.75);
        }

        [Test]
        public void DrumCanCalculateMarkup()
        {
            var drum1 = new Drum("Sonor V171 Rotary Timpany", 212.25, 566.00, "paat paat",
                "ash");
            drum1.CalculateMarkup().ShouldBe(167);
        }
    }
}
