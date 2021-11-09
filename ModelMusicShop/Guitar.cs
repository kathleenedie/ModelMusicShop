using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public class Guitar : Instrument
    {
        private int NumStrings;
        private string Brand;

        public Guitar(string name, InstrumentType type, double buyingPrice, double sellingPrice, string sound, int numStrings, string brand): base(name, type, buyingPrice, sellingPrice, sound)
        {
            this.NumStrings = numStrings;
            this.Brand = brand;
        }

        public int GetNumStrings()
        {
            return NumStrings;
        }

        public string GetBrand()
        {
            return Brand;
        }
    }
}
