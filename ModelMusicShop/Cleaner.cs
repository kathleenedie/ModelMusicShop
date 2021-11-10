using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public class Cleaner : Item
    {
        private InstrumentType InstrumentFor;
        private bool ChemicalCleaner;

        public Cleaner(string name, double buyingPrice, double sellingPrice, ItemCategory category,
            InstrumentType instrumentFor, bool chemicalCleaner) : base(name, buyingPrice, sellingPrice, category)
        {
            this.InstrumentFor = instrumentFor;
            this.ChemicalCleaner = chemicalCleaner;
        }

        public InstrumentType GetInstrumentFor()
        {
            return InstrumentFor;
        }

        public bool GetChemicalCleaner()
        {
            return ChemicalCleaner;
        }
    }
}
