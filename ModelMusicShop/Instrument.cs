using System;

namespace ModelMusicShop
{
    public abstract class Instrument
    {
        private string Name;
        private InstrumentType InstrumentType;
        private double BuyingPrice;
        private double SellingPrice;
        private string Sound;

        public Instrument(string name, InstrumentType instrumentType, double buyingPrice, double sellingPrice, string sound)
        {
            this.Name = name;
            this.InstrumentType = instrumentType;
            this.BuyingPrice = buyingPrice;
            this.SellingPrice = sellingPrice;
            this.Sound = sound;
        }

        public string GetName()
        {
            return Name;
        }

        public InstrumentType GetInstrumentType()
        {
            return InstrumentType;
        }

        public double GetBuyingPrice()
        {
            return BuyingPrice;
        }

        public double GetSellingPrice()
        {
            return SellingPrice;
        }

        public string GetSound()
        {
            return Sound;
        }
    }
}
