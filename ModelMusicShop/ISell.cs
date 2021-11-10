using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    interface ISell
    {
        public double CalculateGrossProfit();

        public double CalculateMarkup();
    }
}
