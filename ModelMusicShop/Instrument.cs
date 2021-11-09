using System;

namespace ModelMusicShop
{
    abstract class Instrument
    {
        public string name { get; set; }
        private InstrumentType type { get; set; }
        private double buyingPrice { get; set; }
        private double sellingPrice { get; set; }
        private string sound { get; set; }

        public Instrument(string name, InstrumentType type, double buyingPrice, double sellingPrice, string sound)
        {
            this.name = name;
            this.type = type;
            this.buyingPrice = buyingPrice;
            this.sellingPrice = sellingPrice;
            this.sound = sound;
        }
    }
}
