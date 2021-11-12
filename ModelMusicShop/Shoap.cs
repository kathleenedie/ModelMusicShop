using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelMusicShop
{
    public class Shoap
    {
        private string Name;
        private List<ISell> Stock;

        public Shoap(string name)
        {
            this.Name = name;
            this.Stock = new List<ISell>();
        }

        public string GetName()
        {
            return Name;
        }

        public List<ISell> GetStock()
        {
            return Stock;
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
    }
}
