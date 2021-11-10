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

        [SetUp]
        public void Setup()
        {
            shop1 = new Shoap();
        }

        [Test]
        public void ShopHasInitialEmptyStock()
        {
            shop1.StockCount().ShouldBe(0);
        }
    }
}
