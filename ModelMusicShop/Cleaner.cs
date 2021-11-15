using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public class Cleaner : Item
    {
        public InstrumentType InstrumentFor { get; set; }
        public bool ChemicalCleaner { get; set; }

        public Cleaner(string name, double buyingPrice, double sellingPrice,
            InstrumentType instrumentFor, bool chemicalCleaner) : base(name, buyingPrice, sellingPrice, ItemCategory.Maintenance)
        {
            this.InstrumentFor = instrumentFor;
            this.ChemicalCleaner = chemicalCleaner;
        }
    }
}
