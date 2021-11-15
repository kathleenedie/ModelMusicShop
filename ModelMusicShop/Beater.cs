using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ModelMusicShop
{
    public class Beater : Item
    {
        public string AgeRange { get; set; }
        public bool Pair { get; set; }

        public Beater(string name, double buyingPrice, double sellingPrice, string ageRange, bool pair): base(name, buyingPrice, sellingPrice, ItemCategory.Accessories)
        {
            this.AgeRange = ageRange;
            this.Pair = pair;
        }
    }
}
