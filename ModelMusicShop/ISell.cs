using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMusicShop
{
    public interface ISell
    {
        public double CalculateGrossProfit();

        public double CalculateMarkup();

        public double TicketPrice();
    }
}
