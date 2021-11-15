using System;
using System.Reflection.Metadata.Ecma335;

namespace ModelMusicShop
{
    public abstract class Instrument : IPlay, ISell

    {
        public string Name { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        public string Sound { get; set; }

        public Instrument(string name, InstrumentType instrumentType, double buyingPrice, double sellingPrice, string sound)
        {
            this.Name = name;
            this.InstrumentType = instrumentType;
            this.BuyingPrice = buyingPrice;
            this.SellingPrice = sellingPrice;
            this.Sound = sound;
        }


        public string Play()
        {
            return $"When I play you hear {Sound}";
        }

        //Should I use midpoint rounding below?
        public double CalculateGrossProfit()
        {
            return Math.Round((SellingPrice - BuyingPrice), 2);
        }

        public double CalculateMarkup()
        {
            return Math.Round((100*(CalculateGrossProfit()/BuyingPrice)), 0);
        }
    }
}
