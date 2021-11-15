using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ModelMusicShop
{
    public class Shoap
    {
        private string Name;
        private List<ISell> Stock;
        private List<ISell> Sold;
        private double Float;
        private double Till;

        public Shoap(string name)
        {
            this.Name = name;
            this.Stock = new List<ISell>();
            this.Float = 100.00;
            this.Till = 0 + Float;
        }

        public string GetName()
        {
            return Name;
        }

        public List<ISell> GetStock()
        {
            return Stock;
        }

        public double GetFloat()
        {
            return Float;
        }

        public double GetTill()
        {
            return Till;
        }

        public int StockCount()
        {
            return Stock.Count;
        }

        public int StockCountOfInstruments()
        { 
            return GetStock().OfType<Instrument>().Count();
        }

        public void AddStockItem(ISell iSell)
        {
            Stock.Add(iSell);
        }

        public void RemoveStockItem(ISell iSell)
        {
            Stock.Remove(iSell);
        }

        public double CalculateStockProfitTotal()
        {
            return Math.Round((Stock.Sum(iSell => iSell.CalculateGrossProfit())), 2) ;
        }
    }
}
