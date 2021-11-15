using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ModelMusicShop
{
    public class Guitar : Instrument
    {
        public int NumStrings { get; set; }
        public string Brand { get; set; }

        public Guitar(string name, double buyingPrice, double sellingPrice, string sound, int numStrings, string brand): base(name, InstrumentType.String, buyingPrice, sellingPrice, sound)
        {
            this.NumStrings = numStrings;
            this.Brand = brand;
        }
    }
}
