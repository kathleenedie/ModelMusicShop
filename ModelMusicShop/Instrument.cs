﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace ModelMusicShop
{
    public abstract class Instrument : IPlay, ISell

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

        public string Play()
        {
            return $"When I play you hear {GetSound()}";
        }

        //Should I use midpoint rounding below?
        public double CalculateGrossProfit()
        {
            return Math.Round((GetSellingPrice() - GetBuyingPrice()), 2);
        }

        public double CalculateMarkup()
        {
            return Math.Round((100*(CalculateGrossProfit()/GetBuyingPrice())), 0);
        }
    }
}
