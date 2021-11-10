using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public class Shoap
    {
        private List<ISell> Stock;

        public Shoap()
        {
            this.Stock = new List<ISell>();
        }

        public List<ISell> GetStock()
        {
            return Stock;
        }

        public int StockCount()
        {
            return Stock.Count;
        }
    }
}
