using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;

namespace ModelMusicShop
{
    public class Shoap
    {
        public string Name { get; set; }
        public List<ISell> Stock { get; set; }
        public List<ISell> Sold { get; set; }
        public double Float { get; set; }
        public double Till { get; set; }
        public int SaleDiscount { get; set; }

        public Shoap(string name, int saleDiscount)
        {
            this.Name = name;
            this.Stock = new List<ISell>();
            this.Sold = new List<ISell>();
            this.Float = 100.00;
            this.Till = 0 + Float;
            this.SaleDiscount = saleDiscount;
        }

        

        public int StockCount()
        {
            return Stock.Count;
        }

        public int StockCountOfInstruments()
        { 
            return Stock.OfType<Instrument>().Count();
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

        public void AddCashToTill(ISell iSell)
        {
            Till = Till + iSell.TicketPrice();
        }

        public void AddSoldItem(ISell iSell)
        {
            Sold.Add(iSell);
        }

        public void SellItem(ISell iSell)
        {
            RemoveStockItem(iSell);
            AddSoldItem(iSell);
            AddCashToTill(iSell);
        }

        public double StockSaleProfitValue()
        {
            return Math.Round((Stock.Sum(iSell => iSell.CalculateGrossProfit())/100*(100-SaleDiscount)), 2);
        }
    }
}
