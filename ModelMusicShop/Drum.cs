using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public class Drum : Instrument
    {
        private string Material;

        public Drum (string name, double buyingPrice, double sellingPrice, string sound,
            string material): base(name, InstrumentType.Percussion, buyingPrice, sellingPrice, sound)
        {
            this.Material = material;
        }

        public string GetMaterial()
        {
            return Material;
        }
    }
}
