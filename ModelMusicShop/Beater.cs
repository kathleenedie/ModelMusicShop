using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ModelMusicShop
{
    public class Beater : Item
    {
        private string AgeRange;
        private bool Pair;

        public Beater(string name, double buyingPrice, double sellingPrice, ItemCategory category, string ageRange, bool pair): base(name, buyingPrice, sellingPrice, category)
        {
            this.AgeRange = ageRange;
            this.Pair = pair;
        }

        public string GetAgeRange()
        {
            return AgeRange;
        }

        public bool GetPair()
        {
            return Pair;
        }
    }
}
