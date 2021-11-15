using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public abstract class Item : ISell
    {
        public string Name { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        public ItemCategory Category { get; set; }

        public Item(string name, double buyingPrice, double sellingPrice, ItemCategory category)
        {
            this.Name = name;
            this.BuyingPrice = buyingPrice;
            this.SellingPrice = sellingPrice;
            this.Category = category;
        }

        public double CalculateGrossProfit()
        {
            return Math.Round((SellingPrice - BuyingPrice), 2);
        }

        public double CalculateMarkup()
        {
            return Math.Round((100 * (CalculateGrossProfit() / BuyingPrice)), 0);
        }

        public double TicketPrice()
        {
            return Math.Round(SellingPrice, 2);
        }
    }
}
