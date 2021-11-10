using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public abstract class Item : ISell
    {
        private string Name;
        private double BuyingPrice;
        private double SellingPrice;
        private ItemCategory Category;

        public Item(string name, double buyingPrice, double sellingPrice, ItemCategory category)
        {
            this.Name = name;
            this.BuyingPrice = buyingPrice;
            this.SellingPrice = sellingPrice;
            this.Category = category;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetBuyingPrice()
        {
            return BuyingPrice;
        }

        public double GetSellingPrice()
        {
            return SellingPrice;
        }

        public ItemCategory GetCategory()
        {
            return Category;
        }

        public double CalculateGrossProfit()
        {
            return Math.Round((GetSellingPrice() - GetBuyingPrice()), 2);
        }

        public double CalculateMarkup()
        {
            return Math.Round((100 * (CalculateGrossProfit() / GetBuyingPrice())), 0);
        }
    }
}
